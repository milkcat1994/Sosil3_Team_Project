using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.IO;            //for using StreamReader/Writer_Class
using System.Net;           //for using IPEndPoint_Class
using System.Net.Sockets;   //for using Socket_Class
using System.Threading;     //for using Thread_Class
using Shell32;              //ShellClass()사용 shell controls 참조 추가
using System.Data.SqlClient;
using NetFwTypeLib;     //Firewall

namespace Project_Server
{
    public partial class Form_Server : Form
    {
        //Client Object and Server IP, Port
        Socket Client = null;
        IPEndPoint point;
        private string WanIP;
        int port;

        private TcpListener m_Listener = null;
        private NetworkStream netStream;
        private StreamReader streamR;
        private StreamWriter streamW;

        //Define for using Buffer
        public const int little_buf_size = 1024;
        private byte[] sendBuffer = new byte[little_buf_size * 1];
        private byte[] readBuffer = new byte[little_buf_size * 1];
        byte[] buffer = new byte[256];

        //Define for receive Client Request
        private string dataType;
        //Client Status
        //문제점 : 다중 클라이언트를 받아야함.
        //각 클라이언트 객체를 배열로 관리하든 하여 각각 요청에 따라 업데이트
        //필수,  클라이언트에 새로고침 버튼을 달아 해당 클라이언트향한 파일전송이
        //스래드에 의해 실행되어 다같이 한번에 받을 수 있도록 해볼것
        //되지 않는다면 스래드 1개만을 이요하여 요청 들어온 순서대로 처리해줄것.
        private bool m_blsClientOn = false;

        //Define Thread Object
        private Thread m_Thread = null;
        
        //File storage_Path in server
        string storage_Path;

        //for read and write at storage_Path
        Folder folder;
        DirectoryInfo di;
        //file Read위한 변수
        FileStream fileReader;

        //For SQL connection _ Path is Server DB Path
        //If you
        SqlConnection sqlConnect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\school\3\Linux\Project\Project_Server\Server_DB.mdf; Integrated Security = True; Connect Timeout = 30");
        //SQL Line
        string query;
        //Adapter between query and DB
        SqlDataAdapter sqla = null;
        //Make a DataTable Object
        DataTable dt = null;

        public class CustomException : Exception
        {
            public CustomException(String message) : base(message)
            { }
        }

        public Form_Server()
        {
            InitializeComponent();
        }

        public string Get_My_IP_Wan()
        {
            //아이피 주소 획득
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    WanIP = ip.ToString();
                    //this.textBox_Down_Up_Load_Log.AppendText( WanIP + "\n" );
                    //break;
                }
            }
            return WanIP;
        }

        private void Form_Server_Load(object sender, EventArgs e)
        {
            //get my ip
            this.textBox_IP.Text = Get_My_IP_Wan().ToString();
            
            //get port
            //Random randNum = new Random();
            //port = randNum.Next(7000, 7999);
            port = 7111;
            this.textBox_Port.Text = port.ToString();
        }

        //서버가 전송한 Music_File_List 받아서 Client쪽 ListView에 보여주기
        public void receive_Thread()
        {
            try
            {// Creates one SocketPermission object for access restrictions
                SocketPermission permission = new SocketPermission(
                NetworkAccess.Accept,     // Allowed to accept connections 
                TransportType.Tcp,        // Defines transport types 
                "",                       // The IP addresses of local host 
                SocketPermission.AllPorts // Specifies all ports 
                );
               
                // Ensures the code to have permission to access a Socket
                permission.Demand();

                IPAddress ip = IPAddress.Parse(WanIP.ToString());
                Client.Blocking = true;
                //서버 첫 구동
                //클라이언트가 없다면 text 출력
                if (!this.m_blsClientOn)
                    this.textBox_Connect_Log.AppendText("Waiting For Client Access...\n");
                //SocketException
                
                point = new IPEndPoint(ip, port);
                Client.Bind(point);
                //소켓 대기상태
                Client.Listen(1);
                Client = Client.Accept();
                //클라이언트의 접속을 기다려 접속시 Client 소켓 정보 초기화
            }
            //Start이후 클라이언트 접속 없이 stop를 하였을 때 발생하는 Exception을 캐치 위함
            catch (SocketException se)
            {
                m_Thread.Abort();
            }

            //클라이언트 접속시 실행
            if (Client.Connected)
            {
                netStream = new NetworkStream(Client);
                streamR = new StreamReader(netStream);
                streamW = new StreamWriter(netStream);

                this.m_blsClientOn = true;
                this.textBox_Connect_Log.AppendText("Client Access!!!\n");
            }

            //Receive Client Request
            while (this.m_blsClientOn)
            {
                try
                {
                    this.textBox_Down_Up_Load_Log.AppendText("waiting Client request\n");
                    //파일의 타입을 맨 처음 전송 받음
                    dataType = streamR.ReadLine();
                    this.textBox_Down_Up_Load_Log.AppendText("Server dataType : " + dataType + "\n");
                }
                catch
                {
                    this.m_blsClientOn = false;
                    return;
                }

                //패킷 타입 분석 이후 패킷 종류에 따라 나눠서 사용함.
                if (dataType.Equals("Login"))
                {
                    Task Login_Task = new Task(new Action(Decision_Approved));
                    Login_Task.Start();
                    Login_Task.Wait();
                    Login_Task.Dispose();
                }
                else if (dataType.Equals("Project_Open"))
                {
                    Task Project_Open_Task = new Task(new Action(Project_Open));
                    Project_Open_Task.Start();
                    Project_Open_Task.Wait();
                    Project_Open_Task.Dispose();
                }
                else if (dataType.Equals("File_Open"))
                {
                    //Task가 수행하는 함수 수정 해야함
                    Task File_Open_Task = new Task(new Action(File_Open));
                    File_Open_Task.Start();
                    try
                    {
                        File_Open_Task.Wait();
                    }
                    catch (AggregateException ae)
                    {
                        foreach (var e in ae.InnerExceptions)
                        {
                            // Handle the custom exception.
                           Console.WriteLine(e.Message);
                        }
                    }
                    File_Open_Task.Dispose();
                }
                else if (dataType.Equals("File_DownLoad"))
                {
                    /*
                    //Task가 수행하는 함수 수정 해야함
                    Task File_DownLoad_Task = new Task(new Action(Send_Project_file));
                    File_DownLoad_Task.Start();
                    File_DownLoad_Task.Wait();
                    File_DownLoad_Task.Dispose();
                    */
                }
                else if (dataType.Equals("Client UpLoad"))
                {
                    //추가구현 클라이언트에서 파일 업로드
                    //this.receiveMp3FiletoClient();
                }
            }
        }

        private void Decision_Approved()
        {
            this.Invoke(new MethodInvoker(delegate ()
            {
                string query = streamR.ReadLine();
                //receive User ID at Client
                string user_ID = streamR.ReadLine();

                //Adapter between query and DB
                sqla = new SqlDataAdapter(query, sqlConnect);
                //Make a DataTable Object
                dt = new DataTable();
                //find attribute your sql
                sqla.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    streamW.WriteLine("Approved");
                    streamW.Flush();
                    textBox_Down_Up_Load_Log.AppendText("Approved to Client\n");
                    //find and send ProjectStatus
                    textBox_Down_Up_Load_Log.AppendText("ProjectMenu <- request receive success\n");

                    var Send_Project_Status_Task = Task<string>.Run(() => FindProjectStatus(user_ID));
                        Send_Project_Status_Task.Wait();
                }
                else
                {
                    textBox_Down_Up_Load_Log.AppendText("NotApproved to Client\n");
                    streamW.WriteLine("NotApproved");
                    streamW.Flush();
                }
            }));
        }

        private void FindProjectStatus(string user_ID)
        {
            //Find Pname, Pno, Ppath, p_start_date and p_end_date in PROJECT table
            query = "select Pname, Pno, Ppath, p_start_date, p_end_date"
                + " from PROJECT AS pro, PART_IN AS part"
                + " where pro.Pno = part.Pnumber"
                + " and part.ID = '" + user_ID + "'";

            //Adapter between query and DB
            sqla = new SqlDataAdapter(query, sqlConnect);
            //Make a DataTable Object
            dt = new DataTable();
            //find attribute your sql
            sqla.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //Send Project status
                streamW.WriteLine("Project status");
                streamW.Flush();
                //Send 5-times
                //Send Project name
                streamW.WriteLine(dt.Rows[i]["Pname"].ToString());
                //Send Project number
                streamW.WriteLine(dt.Rows[i]["Pno"].ToString());
                //Send Project end_date
                streamW.WriteLine(dt.Rows[i]["p_end_date"].ToString());
                //Send Project path
                streamW.WriteLine(dt.Rows[i]["Ppath"].ToString());
                //Send Project start_date
                streamW.WriteLine(dt.Rows[i]["p_start_date"].ToString());
                streamW.Flush();
                textBox_Down_Up_Load_Log.AppendText("Pname_" + dt.Rows[i]["Pname"] + "\n");
            }
        }

        //Send a File List to Client 
        private void Send_Project_Entry(string Ppath)
        {
            //Find File Status in PROJECT
            query = "select Fname, Ftype, Fsize"
                + " from PROJECT AS pro, PROJECT_FILE_INFORM AS fin"
                + " where pro.Pno = fin.Pno"
                + " and pro.Ppath = '" + Ppath + "'";

            //Adapter between query and DB
            sqla = new SqlDataAdapter(query, sqlConnect);
            //Make a DataTable Object
            dt = new DataTable();
            //find attribute your sql
            sqla.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //Send Project status
                streamW.WriteLine("File_List");
                streamW.Flush();
                //Send 5-times
                //Send Project name
                streamW.WriteLine(dt.Rows[i]["Fname"].ToString());
                //Send Project end_date
                streamW.WriteLine(dt.Rows[i]["Ftype"].ToString());
                //Send Project number
                streamW.WriteLine(dt.Rows[i]["Fsize"].ToString());
                streamW.Flush();
                textBox_Down_Up_Load_Log.AppendText("Fname_" + dt.Rows[i]["Fname"] + "\n");
            }
        }

        private void Send_Txt_File(string full_File_Path)
        {
            FileStream fileReader = new FileStream(full_File_Path, FileMode.Open, FileAccess.Read);

            // 패킷 내용을 바일 크기 받는것 추가시키기
            int fileLength = (int)fileReader.Length;
            //파일 보낼 횟수
            int count = fileLength / little_buf_size + 1;
            //파일 읽기 위한 BinaryReader 객체 생성
            BinaryReader reader = new BinaryReader(fileReader);
            //파일 크기 전송 위해 바이트 배열로 전환
            buffer = BitConverter.GetBytes(fileLength);
            streamW.WriteLine(fileLength);
            streamW.Flush();

            //파일 전송 시작
            for (int i = 0; i < count; i++)
            {
                sendBuffer = reader.ReadBytes(little_buf_size);
                //읽은 길이만큼 클라로 전송
                Client.Send(sendBuffer);
            }

            fileReader.Close();
            reader.Close();
        }

        /*
        private void Send_Project_file()
        {
            //선택한 파일 이름, Pno를 클라이언트로 부터 받아서
            //해당 파일이름, Pno를 이용하여 query문 작성, 찾아내서 해당 파일 전송
            string storage_Path = Ppath;
            //파일 정보 얻어오는 코드 + 폴더 경로 지정
            //사용시 참조중 Shell32의 속성에서 interop를 false로 수정
            ShellClass sc = new ShellClass();
            folder = sc.NameSpace(storage_Path);
            di = new DirectoryInfo(storage_Path);

            //내부 파일 확인, .mp3의 확장명이 아니라면 listView에 저장하지 않음
            textBox_Down_Up_Load_Log.AppendText("Send Start ProjectStatus to Client\n");
            foreach (var item in di.GetFiles())
            {
                streamW.WriteLine("Down_Project_File");
                streamW.Flush();
                //find and send ProjectStatus

                //여기서 foreach 돌면서 전송을 하여야함.
                FileStream fileReader = new FileStream(Ppath, FileMode.Open, FileAccess.Read);

                // 패킷 내용을 받는 크기 받는것 추가시키기
                int fileLength = (int)fileReader.Length;
                //파일 보낼 횟수
                int count = fileLength / little_buf_size + 1;
                //파일 읽기 위한 BinaryReader 객체 생성
                BinaryReader reader = new BinaryReader(fileReader);
                //파일 크기 전송 위해 바이트 배열로 전환
                buffer = BitConverter.GetBytes(fileLength);
                streamW.WriteLine(fileLength);
                streamW.Flush();

                //파일 전송 시작
                for (int i = 0; i < count; i++)
                {
                    sendBuffer = reader.ReadBytes(little_buf_size);
                    //읽은 길이만큼 클라로 전송
                    Client.Send(sendBuffer);
                }

                fileReader.Close();
                reader.Close();
            }
            textBox_Down_Up_Load_Log.AppendText("Send Success ProjectStatus to Client\n");
        }
        */

        private void Project_Open()
        {
            this.Invoke(new MethodInvoker(delegate ()
            {
                //receive query at Client
                string query = streamR.ReadLine();

                textBox_Down_Up_Load_Log.AppendText( query + "\n");
                //Adapter between query and DB
                sqla = new SqlDataAdapter(query, sqlConnect);
                //Make a DataTable Object
                dt = new DataTable();
                //find attribute your sql
                sqla.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    //Send Project Status to Client
                    textBox_Down_Up_Load_Log.AppendText("find success Project_File_Status\n");
                    var Send_Project_Folder_Entry = Task<string>.Run(() => Send_Project_Entry(dt.Rows[0]["Ppath"].ToString()));
                    Send_Project_Folder_Entry.Wait();
                }
                else
                {
                    textBox_Down_Up_Load_Log.AppendText("Not exist Project name : "+"\n");
                    streamW.WriteLine("Not_Open_Project");
                    streamW.Flush();
                }
            }));
        }

        private void File_Open()
        {
            this.Invoke(new MethodInvoker(delegate ()
            {
                //Receive Current Project Number
                string tempString = streamR.ReadLine();
                int Project_Number = Convert.ToInt32(tempString);
                string File_Name = streamR.ReadLine();

                query = "select Ppath "
                    + "from PROJECT "
                    + "where Pno = '" + Project_Number + "'";

                //Adapter between query and DB
                sqla = new SqlDataAdapter(query, sqlConnect);
                //Make a DataTable Object
                dt = new DataTable();
                //find attribute your sql
                sqla.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    //Save File Path
                    string full_File_Path = dt.Rows[0]["Ppath"] + "\\" + File_Name;
                    full_File_Path = full_File_Path.Replace("\\","\\\\");
                    //var Send_File_Txt = Task<string>.Run(() => Send_Txt_File(full_File_Path));
                    //Send_File_Txt.Wait();
                    MessageBox.Show(full_File_Path);
                    FileStream fileReader = new FileStream(full_File_Path, FileMode.Open, FileAccess.Read);

                    // 패킷 내용을 바일 크기 받는것 추가시키기
                    int fileLength = (int)fileReader.Length;
                    //파일 보낼 횟수
                    int count = fileLength / little_buf_size + 1;
                    //파일 읽기 위한 BinaryReader 객체 생성
                    BinaryReader reader = new BinaryReader(fileReader);
                    //파일 크기 전송 위해 바이트 배열로 전환
                    buffer = BitConverter.GetBytes(fileLength);
                    streamW.WriteLine(fileLength);
                    streamW.Flush();

                    //파일 전송 시작
                    for (int i = 0; i < count; i++)
                    {
                        sendBuffer = reader.ReadBytes(little_buf_size);
                        //읽은 길이만큼 클라로 전송
                        Client.Send(sendBuffer);
                        textBox_Down_Up_Load_Log.AppendText(sendBuffer.ToString());
                    }

                    fileReader.Close();
                    reader.Close();

                }
                else
                {
                    textBox_Down_Up_Load_Log.AppendText("Not exist File Name  and number : \n");
                }
            }));
        }

        //Set Storage_Path
        private void button_Find_Path_Click(object sender, EventArgs e)
        {
            this.folder_Browser_Dialog.ShowDialog();
            
            //선택한 경로 textBox에 나타냄
            storage_Path = this.folder_Browser_Dialog.SelectedPath;
            this.textBox_Storage_Path.Text = storage_Path;
        }

        private void button_Server_Start_Click(object sender, EventArgs e)
        {
            if (button_Server_Start.Text.Equals("Stop"))
            {
                Client.Close();
                m_blsClientOn = false;
                button_Server_Start.Text = "Start";
                label_Server_Status.Text = "Not Running";
                this.label_Server_Status.ForeColor = Color.Red;
                textBox_Connect_Log.AppendText("Server Stopped\n");
            }
            /*
            else if (textBox_Storage_Path.Text == "")
            {
                MessageBox.Show("경로가 선택되지 않았습니다. 경로를 다시 지정하십시오.", "Error", MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }
            */
            else if (button_Server_Start.Text.Equals("Start"))
            {
                //Socket 변수 초기화
                Client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //스래드로 RUN함수 실행
                this.m_Thread = new Thread(new ThreadStart(receive_Thread));
                this.m_Thread.Start();

                //Log 추가 및 button의 text 수정
                textBox_Connect_Log.AppendText("Server - Start\n");
                button_Server_Start.Text = "Stop";
                label_Server_Status.Text = "Running";
                this.label_Server_Status.ForeColor = Color.BlueViolet;
            }
        }

        private void Form_Server_FormClosed(object sender, FormClosedEventArgs e)
        {
            //해당 값들에 대해 널값이 아닌경우에만 실행하여 exit실행
            if (this.m_Listener != null)
                this.m_Listener.Stop();
            if (this.m_Thread != null)
                this.m_Thread.Abort();
            if (this.fileReader != null)
                this.fileReader.Close();
            if (this.Client != null)
                this.Client.Close();
            if (this.netStream != null)
                this.netStream.Close();
            if (this.streamR != null)
                this.streamR.Close();
            if (this.streamW != null)
                this.streamW.Close();
        }
    }
}
