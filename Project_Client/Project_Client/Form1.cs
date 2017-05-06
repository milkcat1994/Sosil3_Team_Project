using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Data.SqlClient;
using System.IO;            //for using StreamReader/Writer_Class
using System.Net;           //for using IPEndPoint_Class
using System.Net.Sockets;   //for using Socket_Class
using System.Threading;     //for using Thread_Class
using Shell32;              //ShellClass()사용 shell controls 참조 추가

namespace Project_Client
{
    public partial class Form_Client : Form
    {
        private Socket Client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private IPEndPoint point;

        private NetworkStream netStream;
        private StreamReader streamR;
        private StreamWriter streamW;
        
        //Define for using Buffer
        public const int little_buf_size = 1024;
        private byte[] sendBuffer = new byte[little_buf_size * 1];
        private byte[] readBuffer = new byte[little_buf_size * 1];
        byte[] buffer = new byte[256];
        private string dataType;    //데이터 타입

        //server와의 연결이 되었는지 확인
        private bool m_blsConnect = false;

        //Define Thread Object
        private Thread m_Thread = null;


        public Form_Client()
        {
            InitializeComponent();
            panel_Login.Visible = false;
            panel_Project_View.Visible = true;

            // 리스트뷰 아이템을 업데이트 하기 시작.
            // 업데이트가 끝날 때까지 UI 갱신 중지.
            listView_Project_1.BeginUpdate();

            // 뷰모드 지정
            listView_Project_1.View = View.Tile;

            // 아이콘을 위해 이미지 지정
            listView_Project_1.LargeImageList = imageList1;
            //listView1.SmallImageList = imageList1;
            
            // 각 파일별로 ListViewItem객체를 하나씩 만듦
            // 파일명, 사이즈, 날짜 정보를 추가
            ListViewItem lvi = new ListViewItem("test1");
            lvi.SubItems.Add("123");
            lvi.SubItems.Add("1234-12-12");
            lvi.ImageIndex = 0;
            
            listView_Project_1.Items.Add(lvi);

            lvi = new ListViewItem("test2");
            lvi.SubItems.Add("321");
            lvi.SubItems.Add("4321-21-21");
            lvi.ImageIndex = 0;
            // ListViewItem객체를 Items 속성에 추가
            listView_Project_1.Items.Add(lvi);

            // 컬럼명과 컬럼사이즈 지정
            listView_Project_1.Columns.Add("Project Name", 30, HorizontalAlignment.Left);
            listView_Project_1.Columns.Add("Size", 20, HorizontalAlignment.Left);
            listView_Project_1.Columns.Add("Date", 10, HorizontalAlignment.Left);

            // 리스뷰를 Refresh하여 보여줌
            listView_Project_1.EndUpdate();
            
        }
        
        //receive Server Request
        public void receive_Thread()
        {
            while (this.m_blsConnect)
            {
                try
                {
                    //read Server Request Type
                    dataType = streamR.ReadLine();
                }
                catch
                {
                    this.m_blsConnect = false;
                    return;
                }
                
                //Music List를 Server Music List에 추가시켜줌
                if (dataType.Equals("List"))
                {
                    String tempString;
                    //노래제목
                    tempString = streamR.ReadLine();
                    //한 리스트를 다 받고 난뒤 리스트의 마지막일 경우 List에 해당하는 루프를 빠져나옴
                    ListViewItem lv_Item = new ListViewItem(tempString);
                    //가수이름
                    tempString = streamR.ReadLine();
                    lv_Item.SubItems.Add(tempString);
                    //플레이시간
                    tempString = streamR.ReadLine();
                    lv_Item.SubItems.Add(tempString);
                    //음질
                    tempString = streamR.ReadLine();
                    lv_Item.SubItems.Add(tempString);

                   // this.listView_Server_Music_List.Items.Add(lv_Item);
                }
                //서버로 부터 파일을 전송받아 해당 경로에 파일 생성
                /*
                else if (dataType.Equals("Music_File"))
                {

                    //파일 크기 수신
                    string tempString = streamR.ReadLine();
                    int fileLength = Convert.ToInt32(tempString);
                    int totalLength = 0;

                    //노래제목
                    string music_Name = streamR.ReadLine();
                    ListViewItem lv_Item = new ListViewItem(music_Name);
                    //가수이름
                    string music_Singer = streamR.ReadLine();
                    lv_Item.SubItems.Add(music_Singer);
                    //플레이시간
                    string play_Time = streamR.ReadLine();
                    lv_Item.SubItems.Add(play_Time);
                    //음질
                    string bit_Rate = streamR.ReadLine();
                    lv_Item.SubItems.Add(bit_Rate);


                    //open and create storage Path
                    string storage_File = textBox_Storage_Path.Text.ToString() + "\\" + music_Name + ".mp3";
                    storage_File.Replace("\\", "\\\\");
                    FileStream stream = new FileStream(storage_File, FileMode.Create, FileAccess.Write);

                    BinaryWriter writer = new BinaryWriter(stream);
                    while (totalLength < fileLength)
                    {
                        int receiveLength = Client.Receive(readBuffer);
                        writer.Write(readBuffer, 0, receiveLength);
                        totalLength += receiveLength;
                        //12.2_score : 0.3
                        progressBar_Download.Value = Convert.ToInt32(((double)totalLength / (double)fileLength) * 100);
                    }
                    stream.Close();
                    writer.Close();

                    //13.1_score : 0.8
                    //Play List View에 해당 파일 추가
                    this.listView_Play_List.Items.Add(lv_Item);

                    //array List 에 받은 데이터 삽입
                    player_ArrList.Add(music_Name);
                    //add file Length
                }*/
            }
        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                //IP, Port입력에 따른 예외처리
                //Client.Connect(point)의 실패에 따른 예외처리 구간
                if (textBox_IP.Text == "" || textBox_Port.Text == "")
                    throw new ObjectDisposedException("null");
                IPAddress ip = IPAddress.Parse(this.textBox_IP.Text);
                //연결지점 설정
                point = new IPEndPoint(ip, Convert.ToInt32(this.textBox_Port.Text));
                //해당 IP, Port와의 연결 시도
                Client.Connect(point);

                //성공시 3개의 Stream 초기화
                netStream = new NetworkStream(Client);
                streamR = new StreamReader(netStream);
                streamW = new StreamWriter(netStream);
            }//IP, Port가 입력되지 않았을 경우
            catch (ObjectDisposedException ode)
            {
                //IP 또는 Port가 입력되지 않고 Connect 버튼이 눌린경우
                MessageBox.Show("IP 혹은 Port Number가 설정되지 않았습니다.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }//Server가 없을 경우
            catch (SocketException se)
            {
                //Server가 Start되지 않은 경우
                MessageBox.Show("Server가 구동중이지 않습니다.");
                return;
            }//인자가 없는경우
            catch (ArgumentNullException ane)
            {
                MessageBox.Show(ane.ToString() + " occure");
                return;
            }
            //연결 완료시 true로 변경
            this.m_blsConnect = true;

            //Change Panel_visible
            panel_Connect.Visible = false;
            panel_Login.Visible = true;

            //received Server Request using while()
            //스래드로 RUN함수 실행
            this.m_Thread = new Thread(new ThreadStart(receive_Thread));
            this.m_Thread.Start();
        }

        /*
        //Logout button Click Method
        private void button2_Click(object sender, EventArgs e)
        {
            Form_Client.ActiveForm.Width = 600;
            Form_Client.ActiveForm.Height = 600;
            panel_Connect.Visible = true;
        }
        */

        private void button_Login_Click(object sender, EventArgs e)
        {
            //For SQL connection _ Path is Server DB Path
            SqlConnection sqlCon = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\school\3\Linux\Project\Project_Server\Project_Server\Server_DB.mdf; Integrated Security = True; Connect Timeout = 30");
            //If you want to select attribute in Server DB
            string query = "select * from Login where Id ='" + textBox_ID.Text.Trim() + "'and password = '" + textBox_PW.Text.Trim() + "'";
            //Adapter between query and DB
            SqlDataAdapter sqla = new SqlDataAdapter(query, sqlCon);
            //Make a DataTable Object
            DataTable dt = new DataTable();
            //find attribute your sql
            sqla.Fill(dt);

            //if it find ID, PW in table -> Connect_Panel_UnVisible, Login_Panel_Visible
            //and Resize Form_Size
            if (dt.Rows.Count == 1)
            {
                panel_Connect.Visible = false;
                panel_Project_View.Visible = true;
                //Form_Client.ActiveForm.Width = 200;
                //Form_Client.ActiveForm.Height = 200;
                this.ClientSize = new System.Drawing.Size(530, 340);
            }
            //If it not find ID, PW in table -> Show a Message Box _ Error Message
            else
            {
                MessageBox.Show("ID및 PW를 찾지 못하였습니다.\n 다시 확인하세요",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form_Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            Client.Close();
            return;
        }

        private void Form_Client_Load(object sender, EventArgs e)
        {
            textBox_IP.Text = "192.168.56.1";
            textBox_Port.Text = "7111";
            this.ClientSize = new System.Drawing.Size(500, 460);
            //this.ClientSize = new System.Drawing.Size(300, 230);
        }
    }
}
