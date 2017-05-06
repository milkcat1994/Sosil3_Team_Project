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

namespace Project_Server
{
    public partial class Form_Server : Form
    {
        //Client Object and Server IP, Port
        Socket Client = null;
        IPEndPoint point;
        private String WanIP;
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
                    break;
                }
            }
            return WanIP;
        }

        private void Form_Server_Load(object sender, EventArgs e)
        {
            //get my ip
            this.textBox_IP.AppendText(Get_My_IP_Wan());
            
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
            {
                //Get_My_IP_Wan을 Form_Load를 통해 사용하여 ip주소값 저장, Listener실행
                IPAddress ip = IPAddress.Parse(WanIP);

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
                    //파일의 타입을 맨 처음 전송 받음
                    dataType = streamR.ReadLine();
                    //this.textBox_Down_Up_Load_Log.AppendText("Server dataType : " + dataType + "\n");
                }
                catch
                {
                    this.m_blsClientOn = false;
                    return;
                }

                //패킷 타입 분석 이후 패킷 종류에 따라 나눠서 사용함.
                if (dataType.Equals("Client_Request"))
                {
                    //8.2_score : 1
                    //클라요청은 음악 이름을 받음
                    //뮤직 이름 전송 위한 수신
                    string tempString = streamR.ReadLine();
                    //this.sendMp3FiletoClient(tempString);
                }
                else if (dataType.Equals("Client UpLoad"))
                {
                    //추가구현 클라이언트에서 파일 업로드
                    //this.receiveMp3FiletoClient();
                }
            }
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
                label_Server_Status.Text = "Running";
                this.label_Server_Status.ForeColor = Color.BlueViolet;
                textBox_Connect_Log.AppendText("Server Stopped\n");
            }
            else if (textBox_Storage_Path.Text == "")
            {
                MessageBox.Show("경로가 선택되지 않았습니다. 경로를 다시 지정하십시오.", "Error", MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }
            else if (button_Server_Start.Text.Equals("Start"))
            {
                //Socket 변수 초기화
                Client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //스래드로 RUN함수 실행
                this.m_Thread = new Thread(new ThreadStart(receive_Thread));
                this.m_Thread.Start();

                //Log 추가 및 button의 text 수정
                textBox_Connect_Log.AppendText("Server - Start\n");
                textBox_Connect_Log.AppendText("Storage Path : " + this.storage_Path + "\n");
                button_Server_Start.Text = "Stop";
                label_Server_Status.Text = "Not Running";
                this.label_Server_Status.ForeColor = Color.Red;
            }
        }
    }
}
