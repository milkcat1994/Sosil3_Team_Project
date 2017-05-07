﻿using System;
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
using System.Collections;

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

        //For SQL connection _ Path is Server DB Path
        SqlConnection sqlConnect = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=D:\school\3\Linux\Project\Project_Server\Server_DB.mdf;Integrated Security = True; Connect Timeout = 30");
        //SQL Line
        string query;
        //Adapter between query and DB
        SqlDataAdapter sqla = null;
        //Make a DataTable Object
        DataTable dt = null;
        
        public struct ProjectStatus
        {
            public string name;
            public string end_date;
            public string number;
            public string path;
            public string start_date;
            
            public ProjectStatus(string name, string number, string end_date, string path, string start_date)
            {
                this.name = name;
                this.number = number;
                this.end_date = end_date;
                this.path = path;
                this.start_date = start_date;
            }
        }

        public List<ProjectStatus> projectList = new List<ProjectStatus>();

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
                if (dataType.Equals("Project status"))
                {
                    //Receive Project status
                    ProjectStatus tempPs;
                    //Project name
                    string Project_name = streamR.ReadLine();
                    ListViewItem lvi = new ListViewItem(Project_name);
                    //Project end_date
                    string Project_end_date = streamR.ReadLine();
                    lvi.SubItems.Add(Project_end_date);
                    lvi.ImageIndex = 0;

                    string Project_number = streamR.ReadLine();
                    string Project_path = streamR.ReadLine();
                    string Project_start_date = streamR.ReadLine();

                    tempPs = new ProjectStatus(Project_name, Project_end_date,
                        Project_number, Project_path, Project_start_date);
                    projectList.Add(tempPs);
                    listView_Project_1.Items.Add(lvi);

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
            //If you want to select attribute in Server DB
            query = "select Name from dbo.USERS where ID ='" + textBox_ID.Text.Trim() + "' and PW = '" + textBox_PW.Text.Trim() + "'";
            //Adapter between query and DB
            sqla = new SqlDataAdapter(query, sqlConnect);
            //Make a DataTable Object
            dt = new DataTable();
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

                //request Project Menu
                streamW.WriteLine("Project Menu");
                textBox_log.AppendText("send success to server\n");
                //Send User ID in Project
                string user_ID = textBox_ID.Text.Trim();
                streamW.WriteLine(user_ID);
                streamW.Flush();
                //Find Pno, and Pname, p_start_date, p_end_date, Ppath and send to Client at Server
                textBox_ID.Text = "";
                textBox_PW.Text = "";
                panel_Login.Visible = false;

                panel_Project_View.Visible = true;
                return;
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

        private void button_Create_Project_Click(object sender, EventArgs e)
        {
            //새로운 폼을 띄워 함께 진행할 사람을 추가 시키는 형태로 작성할 것.
            //힘들면 기존 폼을 변형 시켜 할것. <-- 비추천
            //필요한 정보 : Project Name, 참여자 ID, P_start_Date, P_end_Date
            //자동으로 정해야 하는 정보 : Pno -> 현재 최대 Pno에서 +1  <-- Arrary List를
            //이용하여 유동적인 Count이용할것.
            //Ppath의 경우 Project Name을 이용하여 서버의 Default Path + Project Name으로
            //정하여 서버에서 폴더를 생성해 줄것.
        }

        private void button_Project_Open_Click(object sender, EventArgs e)
        {
            //save Selected item's index
            var index_Sel_Columns = listView_Project_1.SelectedIndices;

            int index = index_Sel_Columns[0];

            //get name
            string Project_Name = listView_Project_1.Items[index].SubItems[0].Text;
            string Project_Number = listView_Project_1.Items[index].SubItems[1].Text;
            MessageBox.Show("Project_name : " + Project_Name.Trim() + "\nProject_Number : " + Project_Number.Trim());
            //sql을 이용한 해당 Project Name과 Project Number을 이용해서 해당 Project Path찾기
            //string query = "select Ppath from PROJECT where Pname ='" + Project_Name.Trim() + "'and Pno = '" + Project_Number.Text.Trim() + "'";
            //Ppath를 서버로 전송 해당 경로에 있는 파일을 모두 불러와서 도식(ListView_Tile)
            //도식이후 파일 타입 : txt, jpeg, zip, 등등을 파악하여 imageList다르게 설정,
            //다운로드 버튼은 모두 작동, Double Click의 경우 txt일경우에 메모장을 띄울 수 있나?
            //이미지도 Double Click의 경우 다르게 해보던지요..
                        
        }

        public Form_Client()
        {
            InitializeComponent();
            panel_Connect.Visible = true;
            panel_Login.Visible = false;
            panel_Project_View.Visible = false;

            // 리스트뷰 아이템을 업데이트 하기 시작.
            // 업데이트가 끝날 때까지 UI 갱신 중지.
            listView_Project_1.BeginUpdate();

            // 뷰모드 지정
            listView_Project_1.View = View.Tile;

            // 아이콘을 위해 이미지 지정
            listView_Project_1.LargeImageList = imageList1;

            // 컬럼명과 컬럼사이즈 지정
            listView_Project_1.Columns.Add("Project_Name", 30, HorizontalAlignment.Left);
            listView_Project_1.Columns.Add("Project_End_Date", 10, HorizontalAlignment.Left);

            // 리스트뷰를 Refresh하여 보여줌
            listView_Project_1.EndUpdate();

        }
    }
}
