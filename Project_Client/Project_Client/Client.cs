using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;            //for using StreamReader/Writer_Class
using System.Net;           //for using IPEndPoint_Class
using System.Net.Sockets;   //for using Socket_Class
using System.Threading;     //for using Thread_Class

namespace Project_Client
{
    public partial class Form_Client : Form
    {
        public delegate void FormSendDataHandler(string[] start_Date, string[] end_Date);
        public event FormSendDataHandler ParentFormSendEvent;

        private Socket Client;
        private IPEndPoint point;

        private NetworkStream netStream;
        private StreamReader streamR;
        private StreamWriter streamW;

        //for Create, join, Leave : Project
        Create_Project cp;
        Join_Project jp;
        Leave_Project lp;

        //warning System come deadLine Project
        Warning_DeadLine wd;

        //For Make Calender View
        Calender calender;
        public string[] start_Date, end_Date;

        //Define for using Buffer
        public const int little_buf_size = 1024;
        private byte[] sendBuffer = new byte[little_buf_size * 1];
        private byte[] readBuffer = new byte[little_buf_size * 1];
        byte[] buffer = new byte[256];
        private string dataType;    //데이터 타입
        
        //server와의 연결이 되었는지 확인
        private bool m_blsConnect = false;
        private string WanIP;
        //Define Thread Object
        private Thread m_Thread = null;
        
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

        private int current_Project_Number;
        private string current_Project_Name;
        private string current_User_ID;
        private string current_User_IP;
        private string current_DeadLine_Project;
        private string current_DeadLine_Alert_Str;
        //가장 가까운 날짜
        private DateTime close_Date;
        //현재 날짜
        private DateTime current_Date;
        private DateTime max_Date;

        public List<ProjectStatus> projectList = new List<ProjectStatus>();


        public void Get_My_IP_Wan()
        {
            //아이피 주소 획득
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    WanIP = ip.ToString();
                }
            }
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

                //Server의 Project List를 받아 Client Project List에 추가시켜줌
                if (dataType.Equals("Project_Status"))
                {
                    Task proStatus_Task = new Task(new Action(Add_ListView_Project_Status));
                    proStatus_Task.Start();
                    proStatus_Task.Wait();
                }
                //if it find ID, PW in table -> Connect_Panel_UnVisible, Login_Panel_Visible
                //and Resize Form_Size
                else if (dataType.Equals("Approved"))
                {
                    Task Approved_Task = new Task(new Action(Approved));
                    Approved_Task.Start();
                    Approved_Task.Wait();
                }
                //At Open Project List
                else if (dataType.Equals("File_List"))
                {
                    Task File_List_Task = new Task(new Action(Append_File_List));
                    File_List_Task.Start();
                    File_List_Task.Wait();
                }
                else if (dataType.Equals("File_Open"))
                {
                    Task File_Open_Task = new Task(new Action(receive_File_Txt));
                    File_Open_Task.Start();
                    File_Open_Task.Wait();
                }
                else if (dataType.Equals("Down_Project_File"))
                {
                    Task Down_Project_Task = new Task(new Action(Down_Project_File));
                    Down_Project_Task.Start();
                    Down_Project_Task.Wait();
                }
                else if (dataType.Equals("Project_Date_Data"))
                {
                    Task Project_Date_Data_Task = new Task(new Action(send_Project_Date));
                    Project_Date_Data_Task.Start();
                    Project_Date_Data_Task.Wait();
                }
                //If it not find ID, PW in table -> Show a Message Box _ Error Message
                else if (dataType.Equals("NotApproved"))
                {
                    MessageBox.Show("ID및 PW를 찾지 못하였습니다.\n 다시 확인하세요",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dataType.Equals("Exist_Project_To_Join"))
                {
                    this.Invoke(new MethodInvoker(delegate ()
                    {
                        listView_ProjectList.Items.Clear();
                    }));
                    jp.Close();
                }
                else if (dataType.Equals("Exist_Project_To_Leave"))
                {
                    this.Invoke(new MethodInvoker(delegate ()
                    {
                        listView_ProjectList.Items.Clear();
                    }));
                    lp.Close();
                }
                //not exist project name in database
                else if (dataType.Equals("Not_Exist_Project_To_Join"))
                {
                    MessageBox.Show("Fail to join Project");
                }
                else if (dataType.Equals("Not_Exist_Project_To_Leave"))
                {
                    MessageBox.Show("Fail to Leave Project");
                }
                //서버로 부터 파일을 전송받아 해당 경로에 파일 생성
            }
        }

        //listView_File_LList[File name, type, size]
        private void Append_File_List()
        {
            //Ppath를 서버로 전송 해당 경로에 있는 파일을 모두 불러와서 도식(ListView_Tile)
            //도식이후 파일 타입 : txt, jpeg, zip, 등등을 파악하여 imageList다르게 설정,
            //Save File_name, File_type, File_Size, add File_List_View
            this.Invoke(new MethodInvoker(delegate ()
            {
                //File name
                string File_name = streamR.ReadLine();
                ListViewItem lvi = new ListViewItem(File_name);
                //File type
                string File_type = streamR.ReadLine();
                lvi.SubItems.Add(File_type);

                //File size
                string File_size = streamR.ReadLine();
                lvi.SubItems.Add(File_size);
                if (File_type.Trim().Equals("hwp"))
                {
                    lvi.ImageIndex = 0;
                }
                else if (File_type.Trim().Equals("mp3"))
                {
                    lvi.ImageIndex = 1;
                }
                else if (File_type.Trim().Equals("txt"))
                {
                    lvi.ImageIndex = 2;
                }

                listView_File_List.Items.Add(lvi);
                listView_File_List.Update();
                panel_Project_File_View.Update();
            }));
        }

        //------------------Project 내부 파일 다운로드------------------//
        private void Down_Project_File()
        {
            //도식이후 파일 타입 : txt, jpeg, zip, 등등을 파악하여 imageList다르게 설정,
            //이미지도 Double Click의 경우 다르게 해보던지요..

            if (textBox_File_Down_Path.Text.ToString().Equals(""))
            {
                MessageBox.Show("다운로드 경로를 선택하세요");
                return;
            }
            //Find Pno, and Pname, p_start_date, p_end_date, Ppath and send to Client at Server
            this.Invoke(new MethodInvoker(delegate ()
            {
                //receive query at Client
                //파일 크기 수신
                string fileName = streamR.ReadLine();
                string sizeString = streamR.ReadLine();
                int fileLength = Convert.ToInt32(sizeString);
                int totalLength = 0;

                //open and create storage Path
                string storage_File = textBox_File_Down_Path.Text.ToString() + "\\" + fileName;
                storage_File.Replace("\\", "\\\\");
                FileStream stream = new FileStream(storage_File, FileMode.Create, FileAccess.Write);

                BinaryWriter writer = new BinaryWriter(stream);
                while (totalLength < fileLength)
                {
                    int receiveLength = Client.Receive(readBuffer);
                    writer.Write(readBuffer, 0, receiveLength);
                    totalLength += receiveLength;
                }
                stream.Close();
                writer.Close();
            }));
        }

        //------------------Fill Project List_View------------------//
        private void Add_ListView_Project_Status()
        {
            this.Invoke(new MethodInvoker(delegate ()
            {
                //Receive Project status
                ProjectStatus tempPs;
                //Project name
                string Project_name = streamR.ReadLine();
                ListViewItem lvi = new ListViewItem(Project_name);

                //Project number
                string Project_number = streamR.ReadLine();
                lvi.SubItems.Add(Project_number);
                //Project end_date
                string Project_end_date = streamR.ReadLine();
                lvi.SubItems.Add(Project_end_date);
                lvi.ImageIndex = 3;

                close_Date = DateTime.Parse(Project_end_date);
                //음수 : t1<t2    0 : t1==t2  양수 : t1>t2
                //두 날짜 중 더 큰것이 close_Date가 되어 가장 임박한 날짜가 되게된다.
                //current_Date < close_Date < max_Date
                if ((DateTime.Compare(current_Date, close_Date) <= 0) && (DateTime.Compare(close_Date, max_Date)) <= 0)
                {
                    max_Date = close_Date;
                    current_DeadLine_Project = Project_name;
                    current_DeadLine_Alert_Str = current_DeadLine_Project + "가 " + max_Date.ToString("yyyy/MM/dd") + "까지입니다.";
                    wd.label_Warning_Text.Text = current_DeadLine_Alert_Str;
                }
                else if(DateTime.Compare(current_Date, max_Date) == 0)
                {
                    max_Date = close_Date;
                    current_DeadLine_Project = Project_name;
                    current_DeadLine_Alert_Str = current_DeadLine_Project + "가 " + max_Date.ToString("yyyy/MM/dd") + "까지입니다.";
                    wd.label_Warning_Text.Text = current_DeadLine_Alert_Str;
                }
                //close_Date > current_Date
                //do not anything

                
                string Project_path = streamR.ReadLine();
                string Project_start_date = streamR.ReadLine();

                //Add Status in ProjectList Arrary List
                tempPs = new ProjectStatus(Project_name, Project_end_date,
                    Project_number, Project_path, Project_start_date);
                projectList.Add(tempPs);
                //append in ListView
                listView_ProjectList.Items.Add(lvi);
                panel_Project_View.Update();
            }));
        }
        
        //------------------Approved Login------------------//
        private void Approved()
        {
            //setting TextBox_ID, PW to empty, hide and show to panel
            this.Invoke(new MethodInvoker(delegate ()
            {
                //save current user id
                current_User_ID = textBox_ID.Text;
                
                textBox_ID.Text = "";
                textBox_PW.Text = "";
                panel_Login.Hide();
                panel_Project_View.Show();
                panel_Project_View.Update();

                //default Setting date value
                current_Date = DateTime.Now;
                max_Date = new DateTime(9000, 12, 31);
                Show_DeadLine_Warning();
                this.ClientSize = new System.Drawing.Size(500, 400);
            }));
        }

        //--------------Send Project Name, Number for Project Open--------------//
        //------------------flag : Open, Refresh------------------//
        private void Send_Project_Name_Number(string flag)
        {
            //Clear ex_List Information
            listView_File_List.Items.Clear();

            streamW.WriteLine("Project_Open");
            streamW.Flush();
            if (flag.Equals("Open"))
            {
                //save Selected item's index
                var index_Sel_Columns = listView_ProjectList.SelectedIndices;
                int index = index_Sel_Columns[0];
                //get name
                string Project_Name = listView_ProjectList.Items[index].SubItems[0].Text;
                string Project_Number = listView_ProjectList.Items[index].SubItems[1].Text;
                //Save Current Project Name, Number
                current_Project_Name = Project_Name.Trim();
                current_Project_Number = Convert.ToInt32(Project_Number.Trim());
            }

            //Execute below Code at flag -> Refresh, Open
            //send item for update List_View to Server
            streamW.WriteLine(current_Project_Name);
            streamW.Flush();
            streamW.WriteLine(current_Project_Number);
            streamW.Flush();
            listView_File_List.Update();
            panel_Project_View.Update();
        }

        //For Make Calender View//
        private void send_Project_Date()
        {
            //count project for view Calender
            int project_Count = Int32.Parse(streamR.ReadLine());
            start_Date = new string[project_Count];
            end_Date = new string[project_Count];

            for(int i = 0; i< project_Count; i++)
            {
                start_Date[i] = streamR.ReadLine();
                end_Date[i] = streamR.ReadLine();
            }
            //calender.start_Date = start_Date;
            //calender.end_Date = end_Date;
            calender.start_Date = new string[project_Count];
            calender.end_Date = new string[project_Count];
            Array.Copy(start_Date, calender.start_Date, start_Date.Length);
            Array.Copy(end_Date, calender.end_Date, end_Date.Length);
//            calender.start_Date.CopyTo(start_Date,0);
//            calender.end_Date.CopyTo(end_Date, 0);
            calender.flag = true;
            //MessageBox.Show("change success : " + project_Count.ToString());
            //calender.receive_Date_Data(start_Date, end_Date);
            //ParentFormSendEvent(start_Date, end_Date);
        }

        //------------------Project Open View------------------//
        private void button_Project_Open_Click(object sender, EventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate ()
            {
                if (listView_ProjectList.SelectedIndices.Count == 0)
                {
                    return;
                }
                Send_Project_Name_Number("Open");
                panel_Project_View.Hide();
                panel_Project_File_View.Show();
            }));
        }

        //------------------EXIT File View------------------//
        private void button_Back_View_Click(object sender, EventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate ()
            {
                panel_Project_File_View.Hide();
                panel_Project_View.Show();
            }));
        }

        //----------execute Only "*.txt" file for read if not "*.txt" popup error Message----------//
        //----------확장자 명이 txt파일인 경우에만 실행, 아닐경우 에러메시지 도출----------//
        private void button_Open_Click(object sender, EventArgs e)
        {
            //save Selected item's index
            var index_Sel_Columns = listView_File_List.SelectedIndices;
            int index = index_Sel_Columns[0];
            //[File name, type, size]
            string File_Name = listView_File_List.Items[index].SubItems[0].Text;
            string File_Type = listView_File_List.Items[index].SubItems[1].Text;
            if (File_Type.Trim().Equals("txt"))
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    streamW.WriteLine("File_Open");
                    streamW.Flush();
                    //Send current Project Number
                    streamW.WriteLine(current_Project_Number.ToString());
                    //Send File Name
                    streamW.WriteLine(File_Name);
                    streamW.Flush();
                }));
            }
            else
            {
                MessageBox.Show("파일이 txt파일이 아닙니다.\n");
            }
        }
        
        //txt파일을 열기 하였을 경우 바로 text로 확인 할 수 있는 기능
        //문자를 주고 받을 떄 사용하면 될듯 합니다.
        private void receive_File_Txt()
        {
            this.Invoke(new MethodInvoker(delegate ()
            {
                //파일 크기 수신
                string tempString = streamR.ReadLine();
                int fileLength = Int32.Parse(tempString);
                int totalLength = 0;

                //Read text in file
                while (totalLength < fileLength)
                {
                    int receiveLength = Client.Receive(readBuffer);
                    textBox_Open_File_txt.AppendText(Encoding.Default.GetString(readBuffer));
                    totalLength += receiveLength;
                }
                panel_Project_File_View.Hide();
                panel_File_View.Show();
                panel_File_View.Update();
            }));
        }

        //------------------File Download in Project execute------------------//
        //---------------------File Down Path must needed---------------------//
        //-----------------Run Function : Down_Project_File()-----------------//
        private void button_File_DownLoad_Click(object sender, EventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate ()
            {
                if (textBox_File_Down_Path.Equals(""))
                {
                    MessageBox.Show("DownLoad Path isn't it");
                    return;
                }
                //save Selected item's index
                var index_Sel_Columns = listView_File_List.SelectedIndices;
                int index = index_Sel_Columns[0];
                //[File name, type, size]
                string File_Name = listView_File_List.Items[index].SubItems[0].Text;
                string File_Type = listView_File_List.Items[index].SubItems[1].Text;

                streamW.WriteLine("File_DownLoad");
                streamW.Flush();
                //Send current Project Number
                streamW.WriteLine(current_Project_Number.ToString());
                //Send File Name
                streamW.WriteLine(File_Name);
                streamW.Flush();
            }));
        }

        //------------------File Upload execute to Project------------------//
        private void button_File_UpLoad_Click(object sender, EventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate ()
            {
                this.open_File_Dialog.ShowDialog();
                //파일 전체 경로
                string full_File_Path = open_File_Dialog.FileName;
                //확장자 포함 파일이름
                string file_Name = open_File_Dialog.SafeFileName;
                //확장자 제외 파일이름
                //string file_pure_name = Path.GetFileNameWithoutExtension(full_file_path);
                //경로
                string path_Name = full_File_Path.Substring(0, (full_File_Path.Length - file_Name.Length));
                
                //client가 업로드함을 알림
                streamW.WriteLine("File_UpLoad");
                
                //Send current Project Number
                streamW.WriteLine(current_Project_Number.ToString());
                //Send user_ID
                streamW.WriteLine(current_User_ID);
                //Send pure File Name
                streamW.WriteLine(file_Name);
                
                FileStream fileReader = new FileStream(full_File_Path, FileMode.Open, FileAccess.Read);
                // 패킷 내용을 크기 받는것 추가시키기
                int fileLength = (int)fileReader.Length;
                //파일 보낼 횟수
                int count = fileLength / little_buf_size + 1;
                //파일 읽기 위한 BinaryReader 객체 생성
                BinaryReader reader = new BinaryReader(fileReader);
                //파일 크기 전송 위해 바이트 배열로 전환
                buffer = BitConverter.GetBytes(fileLength);
                streamW.WriteLine(fileLength);
                streamW.Flush();
                
                //File transfer Start
                for (int i = 0; i < count; i++)
                {
                    sendBuffer = reader.ReadBytes(little_buf_size);
                    //읽은 길이만큼 클라로 전송
                    Client.Send(sendBuffer);
                }

                fileReader.Close();
                reader.Close();
                //Clear File_ListView for receive new File_List in Project
                listView_File_List.Items.Clear();
            }));
        }

        //------------------Refresh Project View Function------------------//
        private void button_Refresh_Click(object sender, EventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate ()
            {
                Send_Project_Name_Number("Refresh");
            }));
        }

        //------------------text View Panel Exit Function------------------//
        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate ()
            {
                textBox_Open_File_txt.Clear();
                panel_Project_File_View.Show();
                panel_File_View.Hide();
            }));
        }

        //------------------Select DownLoad Path------------------//
        private void button_Path_Select_Click(object sender, EventArgs e)
        {
            this.folder_Browser_Dialog.ShowDialog();
            
            //선택한 경로 textBox에 나타냄 및 get_File_Name 이용해 ListView에 나타냄
            string file_Storage_Path = this.folder_Browser_Dialog.SelectedPath;
            this.textBox_File_Down_Path.Text = file_Storage_Path;
        }

        //------------------LogIn, LogOut Function------------------//
        private void button_Login_Click(object sender, EventArgs e)
        {
            if(textBox_ID.Text.Equals("") || textBox_PW.Text.Equals(""))
            {
                MessageBox.Show("ID 또는 PW를 입력하세요");
                return;
            }
            streamW.WriteLine("Login");
            streamW.Flush();
            //Send User ID in Project
            streamW.WriteLine(textBox_ID.Text.Trim());
            streamW.Flush();
            //Send User PW in Project
            streamW.WriteLine(textBox_PW.Text.Trim());
            streamW.Flush();

            try
            {
                //user ID 전송
                current_User_ID = textBox_ID.Text.Trim();
                streamW.WriteLine(current_User_ID);
                //user IP 전송
                streamW.WriteLine(current_User_IP);
                streamW.Flush();
            }
            catch
            {
                return;
            }

        }

        private void button_Logout_Click(object sender, EventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate ()
            {
                panel_Login.Show();
                panel_Project_View.Hide();
                foreach (ListViewItem item in listView_ProjectList.Items)
                {
                    listView_ProjectList.Items.Remove(item);
                }
                projectList.Clear();
                this.ClientSize = new System.Drawing.Size(280, 170);
            }));
        }

        //------------------Connect, DisConnect Function------------------//
        private void button_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                Client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //IP, Port입력에 따른 예외처리
                //Client.Connect(point)의 실패에 따른 예외처리 구간
                if (textBox_IP.Text == "" || textBox_Port.Text == "")
                    throw new ObjectDisposedException("null");
                IPAddress ip = IPAddress.Parse(this.textBox_IP.Text);
                //save User's IP
                current_User_IP = WanIP;

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
            panel_Connect.Hide();
            panel_Login.Show();
            //Clear IP, Port TextBox
            textBox_IP.Clear();
            textBox_Port.Clear();


            //received Server Request using while()
            //스래드로 RUN함수 실행
            this.m_Thread = new Thread(new ThreadStart(receive_Thread));
            this.m_Thread.Start();
        }
        
        private void button_Disconnect_Click(object sender, EventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate ()
            {
                panel_Connect.Show();
                panel_Login.Hide();
                //Clear IP, Port TextBox
                textBox_ID.Clear();
                textBox_PW.Clear();

                //Socket Disconnect 구현
                streamW.WriteLine("Client_Disconnect");
                streamW.Flush();

                streamR.Close();
                streamW.Close();
                netStream.Close();
                Client.Close();
                Client = null;
            }));
        }
        
        //setting Project Name to join or Leave or Create
        public void approvedProjectName(string ProjectString, string flag)
        {
            //Send Join or Leave Project Option to Server
            if (flag.Equals("Join"))
            {
                streamW.WriteLine("Join_Project");
                streamW.Flush();
            }
            else if (flag.Equals("Leave"))
            {
                streamW.WriteLine("Leave_Project");
                streamW.Flush();
            }

            //Execute below Code when have a flag -> Join or Leave
            if (flag.Equals("Join") || flag.Equals("Leave"))
            {
                //Send want to join or Leave Project Name
                streamW.WriteLine(ProjectString.ToString());
                //Send User ID
                streamW.WriteLine(current_User_ID);
                streamW.Flush();
            }
            //Execute below Code when have a flag -> Create
            else if (flag.Equals("Create"))
            {
                streamW.WriteLine("Create_Project");
                streamW.Flush();
                char sp = ',';
                //Split Project Name, Project_Start_Date, Project_End_Date
                string[] split_String = ProjectString.ToString().Split(sp);
                for(int i =0; i< split_String.Length; i++)
                {
                    streamW.WriteLine(split_String[i]);
                    streamW.Flush();
                }
                //Send User ID
                streamW.WriteLine(current_User_ID);
                streamW.Flush();
                //Clear ListView ProjectList
                this.Invoke(new MethodInvoker(delegate ()
                {
                    listView_ProjectList.Items.Clear();
                }));
                cp.Close();
            }
        }

        //click event Create Project Button
        //show Join_Project Form and receive Join_Project_Name
        private void button_Create_Project_Click(object sender, EventArgs e)
        {
            //Project 이름은 곂치는 것이 없다는 것을 가정으로 할 것.
            if (!cp.Created)
            {
                if (cp.IsDisposed)
                {
                    cp = new Create_Project();   //make Object
                }
                cp.FormSendEvent += new Create_Project.FormSendDataHandler(approvedProjectName);
                cp.Show();
            }
            else
            {
                cp.Activate();
            }
            //필요한 정보 : Project Name, 참여자 ID, P_start_Date, P_end_Date
            //자동으로 정해야 하는 정보 : Pno -> 현재 최대 Pno에서 +1  <-- Arrary List를
            //이용하여 유동적인 Count이용할것.
            //Ppath의 경우 Project Name을 이용하여 서버의 Default Path + Project Name으로
            //정하여 서버에서 폴더를 생성해 줄것.
        }

        //Click event Join Project Button
        //show Join_Project Form and receive Join_Project_Name
        private void button_Join_Project_Click(object sender, EventArgs e)
        {
            if (!jp.Created)
            {
                if (jp.IsDisposed)
                {
                    jp = new Join_Project();   //make Object
                }
                jp.FormSendEvent += new Join_Project.FormSendDataHandler(approvedProjectName);
                jp.Show();
            }
            else
            {
                jp.Activate();
            }
        }

        //Click event Leave Project Button
        //show Leave_Project Form and receive Leave_Project_Name
        private void button_Leave_Project_Click(object sender, EventArgs e)
        {
            if (!lp.Created)
            {
                if (lp.IsDisposed)
                {
                    lp = new Leave_Project();   //make Object
                }
                lp.FormSendEvent += new Leave_Project.FormSendDataHandler(approvedProjectName);
                lp.Show();
            }
            else
            {
                lp.Activate();
            }
        }
        
        //Click event View Calender Button
        //show Leave_Project Form and receive Leave_Project_Name
        private void button_Calender_Click(object sender, EventArgs e)
        {
            if (!calender.Created)
            {
                if (calender.IsDisposed)
                {
                    calender = new Calender();   //make Object
                }
                calender.Owner = this;
                calender.FormSendEvent += new Calender.FormSendDataHandler(approved_Calender_Index);
                calender.Show();
            }
            else
            {
                calender.Activate();
            }
        }

        //자식폼에게서 year, month입력 받아 서버에게 query 작성을 요구
        //즉, 서버에게 year, month를 순서대로 전송 해줌
        private void approved_Calender_Index(int year, int month)
        {
            //send flag to Server
            streamW.WriteLine("Project_Date");

            //Execute below Code

            //Send current selected year
            streamW.WriteLine(current_User_ID);
            streamW.WriteLine(year.ToString());
            //Send month
            streamW.WriteLine(month.ToString());
            streamW.Flush();
        }


        private void Show_DeadLine_Warning()
        {
            if (!wd.Created)
            {
                if (wd.IsDisposed)
                {
                    wd = new Warning_DeadLine(current_DeadLine_Alert_Str);   //make Object
                }
                wd.Show();
            }
            else
            {
                wd.Activate();
            }
        }

        //------------------First Form Function------------------//
        public Form_Client()
        {
            InitializeComponent();
            panel_Connect.Show();
            panel_Login.Hide();
            panel_Project_View.Hide();
            panel_Project_File_View.Hide();
            panel_File_View.Hide();

            //get Client IP
            Get_My_IP_Wan();

            // 뷰모드 지정
            listView_ProjectList.View = View.Tile;

            // 아이콘을 위해 이미지 지정
            listView_ProjectList.LargeImageList = imageList1;

            // 컬럼명과 컬럼사이즈 지정
            listView_ProjectList.Columns.Add("Project_Name", 30, HorizontalAlignment.Left);
            listView_ProjectList.Columns.Add("Project_Number", 3, HorizontalAlignment.Left);
            listView_ProjectList.Columns.Add("Project_End_Date", 10, HorizontalAlignment.Left);

            listView_File_List.Columns.Add("File_Name", 30, HorizontalAlignment.Left);
            listView_File_List.Columns.Add("File_type", 4, HorizontalAlignment.Left);
            listView_File_List.Columns.Add("File_Size", 10, HorizontalAlignment.Left);

            timer1.Start();

            //add Join_Project, Leave_Project Form Object
            cp = new Create_Project();
            jp = new Join_Project();
            lp = new Leave_Project();
            calender = new Calender();

            //default Setting date value
            current_Date = DateTime.Now;
            max_Date = new DateTime(9000, 12, 31);
            current_DeadLine_Alert_Str = current_DeadLine_Project + "가 " + max_Date.ToString("yyyy/MM/dd") + "까지입니다.";
            wd = new Warning_DeadLine(current_DeadLine_Alert_Str);
        }

        //------------------Form Load Function------------------//
        private void Form_Client_Load(object sender, EventArgs e)
        {
            //textBox_IP.Text = "192.168.43.97";
            //textBox_Port.Text = "7111";
            //textBox_ID.Text = "2013726007";
            //textBox_PW.Text = "1234";
            this.ClientSize = new System.Drawing.Size(280, 170);
            //this.ClientSize = new System.Drawing.Size(300, 230);
        }

        //------------------Form_Closed Event Handler------------------//
        private void Form_Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(Client != null)
            {
                streamW.WriteLine("Client_Disconnect");
                streamW.Flush();
            }
            //해당 값들에 대해 널값이 아닌경우에만 실행하여 exit실행
            if (this.streamW != null)
                this.streamW.Close();
            if (this.m_Thread != null)
                this.m_Thread.Abort();
            if (this.Client != null)
                this.Client.Close();
            if (this.netStream != null)
                this.netStream.Close();
            if (this.streamR != null)
                this.streamR.Close();
            return;
        }
        
    }
}
