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

        //for read and write at storage_Path
        Folder folder;
        DirectoryInfo di;
        //file Read위한 변수
        FileStream fileReader;

        //For SQL connection _ Path is Server DB Path
        //If you
        SqlConnection sqlConnect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\school\3\Linux\Project\Project_Server\Server_DB.mdf; Integrated Security = True; Connect Timeout = 30");
        SqlCommand sqlcom = null;

        //SQL Line
        string query;
        //Adapter between query and DB
        SqlDataAdapter sqla = null;
        //Make a DataTable Object
        DataTable dt = null;
        //For save Default Project Path
        string default_Project_Path = "C:\\Users\\user\\Documents";
        //For save Max Project number
        int Max_Pno = 0;

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
            sqlConnect.Open();

            //select Project_number to have same Pname
            query = "select MAX(Pno) As maxPno "
                + "from PROJECT "
                + "where Pno >= 1";

            textBox_Down_Up_Load_Log.AppendText(query + "\n");
            //Adapter between query and DB
            sqla = new SqlDataAdapter(query, sqlConnect);
            //Make a DataTable Object
            dt = new DataTable();
            //find attribute your sql
            sqla.Fill(dt);

            //if find Pno's Max Value in Project table in database
            if (dt.Rows.Count >= 1)
            {
                Max_Pno = Int32.Parse(dt.Rows[0]["maxPno"].ToString());
            }
        }
        
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
                //Client.Blocking = true;
                //서버 첫 구동
                //클라이언트가 없다면 text 출력

                this.Invoke(new MethodInvoker(delegate ()
                {
                    if (!this.m_blsClientOn)
                        this.textBox_Connect_Log.AppendText("Waiting For Client Access...\n");
                }));
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
                this.Invoke(new MethodInvoker(delegate ()
                {
                    netStream = new NetworkStream(Client);
                    streamR = new StreamReader(netStream);
                    streamW = new StreamWriter(netStream);

                    this.m_blsClientOn = true;
                    this.textBox_Connect_Log.AppendText("Client Access!!!\n");
                }));
            }

            //Receive Client Request
            while (this.m_blsClientOn)
            {
                try
                {
                    this.Invoke(new MethodInvoker(delegate ()
                    {
                        this.textBox_Down_Up_Load_Log.AppendText("waiting Client request\n");
                        //파일의 타입을 맨 처음 전송 받음
                        dataType = streamR.ReadLine();
                        this.textBox_Down_Up_Load_Log.AppendText("Server dataType : " + dataType + "\n");
                    }));
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
                    Task File_DownLoad_Task = new Task(new Action(Send_Project_file));
                    File_DownLoad_Task.Start();
                    File_DownLoad_Task.Wait();
                    File_DownLoad_Task.Dispose();
                }
                else if (dataType.Equals("File_UpLoad"))
                {
                    Task File_UpLoad_Task = new Task(new Action(UpLoad_File_Project));
                    File_UpLoad_Task.Start();
                    File_UpLoad_Task.Wait();
                    File_UpLoad_Task.Dispose();
                }
                else if (dataType.Equals("Join_Project"))
                {
                    var Approved_Project_Join_Task = Task<string>.Run(() => Approved_Project_Exist("Join"));
                    Approved_Project_Join_Task.Wait();
                    Approved_Project_Join_Task.Dispose();
                }
                else if (dataType.Equals("Leave_Project"))
                {
                    var Approved_Project_Leave_Task = Task<string>.Run(() => Approved_Project_Exist("Leave"));
                    Approved_Project_Leave_Task.Wait();
                    Approved_Project_Leave_Task.Dispose();
                }
                else if (dataType.Equals("Create_Project"))
                {
                    Task Project_Create_Task = new Task(new Action(Project_Create));
                    Project_Create_Task.Start();
                    Project_Create_Task.Wait();
                    Project_Create_Task.Dispose();
                }
            }
        }

        //For Login
        private void Decision_Approved()
        {
            this.Invoke(new MethodInvoker(delegate ()
            {
                string user_ID = streamR.ReadLine();
                //receive User ID at Client
                string user_PW = streamR.ReadLine();

                query = "select Name from dbo.USERS where ID ='"
                    + user_ID + "' and PW = '" + user_PW + "'";
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
                //Send Project_Status
                streamW.WriteLine("Project_Status");
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
                //Send Project_Status
                streamW.WriteLine("File_List");
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
        
        //--------------Requested DownLoad File to Client--------------//
        private void Send_Project_file()
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
                
                string storage_Path = dt.Rows[0]["Ppath"].ToString();
                //파일 정보 얻어오는 코드 + 폴더 경로 지정
                //사용시 참조중 Shell32의 속성에서 interop를 false로 수정
                ShellClass sc = new ShellClass();
                folder = sc.NameSpace(storage_Path);
                di = new DirectoryInfo(storage_Path);
                
                foreach (var item in di.GetFiles())
                {
                    streamW.WriteLine("Down_Project_File");
                    streamW.Flush();
                    //Send FileStatus
                    streamW.WriteLine(item.Name);
                    streamW.Flush();
                    string requestedFile_Path = (storage_Path + "\\" + item.Name);
                    //여기서 foreach 돌면서 전송을 하여야함.
                    FileStream fileReader = new FileStream(requestedFile_Path, FileMode.Open, FileAccess.Read);
                    textBox_Connect_Log.AppendText(requestedFile_Path);
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
                    textBox_Down_Up_Load_Log.AppendText("Send File : " + requestedFile_Path + "\n");
                }
            }));

        }

        //---------------Requested UpLoad File to Client---------------//
        private void UpLoad_File_Project()
        {
            //추후 추가는 업로드자 게시
            this.Invoke(new MethodInvoker(delegate ()
            {
                //receive data at Client
                string project_Number = streamR.ReadLine();
                string user_ID = streamR.ReadLine();
                string file_Name = streamR.ReadLine();
                //file_Name_Split_Arr[0] : File Name without extension
                //file_Name_Split_Arr[1] : File's extension
                string[] file_Name_Split_Arr = file_Name.Split('.');

                //sql문을 통해 파일 경로를 찾아야함
                query = "select Ppath "
                    + "from PROJECT "
                    + "where Pno = '" + project_Number + "'";

                //Adapter between query and DB
                sqla = new SqlDataAdapter(query, sqlConnect);
                //Make a DataTable Object
                dt = new DataTable();
                //find attribute your sql
                sqla.Fill(dt);
                //save Project Path
                string storage_Path = dt.Rows[0]["Ppath"].ToString();

                //For create File save to file path
                string storage_File_Path = storage_Path + "\\" + file_Name;
                storage_File_Path.Replace("\\", "\\\\");
                FileStream stream = new FileStream(storage_File_Path, FileMode.Create, FileAccess.Write);

                //파일 크기 수신
                string tempString = streamR.ReadLine();
                textBox_Down_Up_Load_Log.AppendText(tempString + "\n");
                int fileLength = Convert.ToInt32(tempString);
                int totalLength = 0;

                textBox_Down_Up_Load_Log.AppendText("pno : "+project_Number+"\n");
                //Pno를 통해 Ppath검색, 파일을 받아 해당 경로에 파일 생성 및 자료 이동
                textBox_Down_Up_Load_Log.AppendText("success make file fileLength : \n"+ fileLength + "\n");

                //의문점 : 992byte가 소실됩니다. 슈바 어디로 쳐 날라간거니
                //write File in File_Path
                BinaryWriter writer = new BinaryWriter(stream);
                while (totalLength < fileLength)
                {
                    int receiveLength = Client.Receive(readBuffer);
                    writer.Write(readBuffer, 0, receiveLength);
                    totalLength += receiveLength;
                }
                stream.Close();
                writer.Close();
                textBox_Down_Up_Load_Log.AppendText("success write file\n");

                //FILE_INFORM 테이블에 해당 파일 정보 업로드
                //Get FileSize
                FileInfo fInfo = new FileInfo(storage_File_Path);
                string file_Size = GetFileSize(fInfo.Length);
                //Fname, Ftype, Fsize
                //insert PROJECT_FILE_INFORM table_Fname, Ftype, Fsize
                query = "insert into PROJECT_FILE_INFORM "
                    + "values("
                    + "" + project_Number + ", '"
                    + file_Name + "', '"
                    + file_Name_Split_Arr[1] + "', '"
                    + file_Size + "')";

                sqlcom = new SqlCommand();
                sqlcom.Connection = sqlConnect;
                sqlcom.CommandText = query;
                //execute query
                sqlcom.ExecuteNonQuery();

                this.Send_Project_Entry(storage_Path);
            }));
        }

        //---------------Requested Open Project to Client---------------//
        private void Project_Open()
        {
            this.Invoke(new MethodInvoker(delegate ()
            {
                //receive data at Client
                string Pname = streamR.ReadLine();
                string Pnumber = streamR.ReadLine();

                query = "select Ppath "
                    + "from PROJECT "
                    + "where Pname ='" + Pname
                    + "'and Pno = '" + Pnumber + "'";

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
        
        //---------------Requested Create Project to Client---------------//
        private void Project_Create()
        {
            this.Invoke(new MethodInvoker(delegate ()
            {
                //receive data at Client
                string Pname = streamR.ReadLine();
                string Ppath = default_Project_Path + "\\" + Pname;
                string Pstartdate = streamR.ReadLine();
                string Penddate = streamR.ReadLine();
                string User_ID = streamR.ReadLine();

                //Create Directory
                Ppath.Replace("\\","\\\\");
                di = new DirectoryInfo(Ppath);
                di.Create();
                
                //increase Max_Pno
                Max_Pno += 1;

                //insert PROJECT table_Pno, Pname, Ppath, P_sstart_date, P_end_date
                query = "insert into PROJECT "
                    + "values("
                    + "'" + Max_Pno + "', '"
                    + Pname + "', '"
                    + Ppath + "', '"
                    + Pstartdate + "', '"
                    + Penddate + "')";

                sqlcom = new SqlCommand();
                sqlcom.Connection = sqlConnect;
                sqlcom.CommandText = query;
                //execute query
                sqlcom.ExecuteNonQuery();

                //insert PART_IN table_add user_id, pnumber
                query = "insert into PART_IN "
                    + "values("
                    + "'" + User_ID + "', '"
                    + Max_Pno + "')";

                sqlcom = new SqlCommand();
                sqlcom.Connection = sqlConnect;
                sqlcom.CommandText = query;
                //execute query
                sqlcom.ExecuteNonQuery();

                textBox_Down_Up_Load_Log.AppendText("success add new Project Information\n");
                //Notice Exist Project Name in database
                streamW.WriteLine("Exist_Project_To_Join");
                streamW.Flush();
                this.FindProjectStatus(User_ID);
            }));
        }

        //--------------Requested Open "*.txt" File to Client--------------//
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
                    streamW.WriteLine("File_Open");
                    //Save File Path
                    string full_File_Path = dt.Rows[0]["Ppath"] + "\\" + File_Name;
                    full_File_Path = full_File_Path.Replace("\\","\\\\");
                    //var Send_File_Txt = Task<string>.Run(() => Send_Txt_File(full_File_Path));
                    //Send_File_Txt.Wait();
                    //FileStream fileReader = new FileStream(full_File_Path, FileMode.Open, FileAccess.Read);
                    string Alltext = File.ReadAllText(full_File_Path);

                    //file 내용의 길이 저장
                    int fileLength = Alltext.Length;
                    //파일 보낼 횟수
                    int count = fileLength / little_buf_size + 1;
                    //파일 크기 전송 위해 바이트 배열로 전환
                    //buffer = BitConverter.GetBytes(fileLength);
                    streamW.WriteLine(fileLength.ToString());
                    textBox_Down_Up_Load_Log.AppendText(fileLength.ToString()+"\n");
                    streamW.Flush();

                    for (int i =0;i<count; i++)
                    {
                        sendBuffer = Encoding.UTF8.GetBytes(Alltext);
                        Client.Send(sendBuffer);
                        textBox_Down_Up_Load_Log.AppendText(Encoding.Default.GetString(sendBuffer));
                    }
                }
                else
                {
                    textBox_Down_Up_Load_Log.AppendText("Not exist File Name  and number : \n");
                }
            }));
        }

        //Approved to Join or Leave in Project
        //flag = Join or Leave
        private void Approved_Project_Exist(string flag)
        {
            this.Invoke(new MethodInvoker(delegate ()
            {
                //receive data at Client
                string Pname = streamR.ReadLine();
                string User_ID = streamR.ReadLine();

                //select Project_number to have same Pname
                query = "select Pno "
                    + "from PROJECT "
                    + "where Pname ='" + Pname + "'";

                textBox_Down_Up_Load_Log.AppendText(query + "\n");
                //Adapter between query and DB
                sqla = new SqlDataAdapter(query, sqlConnect);
                //Make a DataTable Object
                dt = new DataTable();
                //find attribute your sql
                sqla.Fill(dt);

                //if exist Project_Name add UserID in Project table in database
                if (dt.Rows.Count >= 1)
                {
                    //execute below Code to Join Project
                    if (flag.Equals("Join"))
                    {
                        textBox_Down_Up_Load_Log.AppendText("find success Project_Name for join\n");

                        //alter PART_IN table_add user_id, pnumber
                        query = "insert into PART_IN "
                            + "values("
                            + "'" + User_ID + "', '"
                            + dt.Rows[0]["Pno"].ToString() + "')";
                        
                        sqlcom = new SqlCommand();
                        sqlcom.Connection = sqlConnect;
                        sqlcom.CommandText = query;
                        //execute query
                        sqlcom.ExecuteNonQuery();

                        textBox_Down_Up_Load_Log.AppendText("success add Project_Name for join\n");
                        //Notice Exist Project Name in database
                        streamW.WriteLine("Exist_Project_To_Join");
                        streamW.Flush();
                        this.FindProjectStatus(User_ID);
                    }
                    //execute below Code to Leave Project
                    else if (flag.Equals("Leave"))
                    {
                        textBox_Down_Up_Load_Log.AppendText("find success Project_Name for Leave\n");

                        //alter PART_IN table_add user_id, pnumber
                        query = "delete from PART_IN "
                            + "where Pnumber ='" + dt.Rows[0]["Pno"].ToString()
                            + "' and ID = '" + User_ID + "'";

                        sqlcom = new SqlCommand();
                        sqlcom.Connection = sqlConnect;
                        sqlcom.CommandText = query;
                        //execute query
                        sqlcom.ExecuteNonQuery();

                        textBox_Down_Up_Load_Log.AppendText("success add Project_Name for Leave\n");
                        //Notice Exist Project Name in database
                        streamW.WriteLine("Exist_Project_To_Leave");
                        streamW.Flush();
                        this.FindProjectStatus(User_ID);
                    }
                }
                else
                {
                    textBox_Down_Up_Load_Log.AppendText("Not exist Project name for join : " + "\n");
                    streamW.WriteLine("Not_Exist_Project_To_Join");
                    streamW.Flush();
                }
            }));
        }

        //Set Storage_Path
        private void button_Find_Path_Click(object sender, EventArgs e)
        {
            this.folder_Browser_Dialog.ShowDialog();
            
            //선택한 경로 textBox에 나타냄
            string storage_Path = this.folder_Browser_Dialog.SelectedPath;
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

        //For Get File Size Function
        //출처: http://ndolson.com/1362 [엔돌슨의 IT이야기]
        private string GetFileSize(double byteCount)
        {
            string size = "0 Bytes";
            if (byteCount >= 1073741824.0)
                size = String.Format("{0:##.##}", byteCount / 1073741824.0) + " GB";
            else if (byteCount >= 1048576.0)
                size = String.Format("{0:##.##}", byteCount / 1048576.0) + " MB";
            else if (byteCount >= 1024.0)
                size = String.Format("{0:##.##}", byteCount / 1024.0) + " KB";
            else if (byteCount > 0 && byteCount < 1024.0)
                size = byteCount.ToString() + " Bytes";

            return size;
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
