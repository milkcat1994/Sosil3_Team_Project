namespace Project_Client
{
    partial class Form_Client
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Client));
            this.panel_ID = new System.Windows.Forms.Panel();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label_ID = new System.Windows.Forms.Label();
            this.panel_PW = new System.Windows.Forms.Panel();
            this.textBox_PW = new System.Windows.Forms.TextBox();
            this.label_PW = new System.Windows.Forms.Label();
            this.panel_IP = new System.Windows.Forms.Panel();
            this.textBox_IP = new System.Windows.Forms.TextBox();
            this.label_IP = new System.Windows.Forms.Label();
            this.panel_Port = new System.Windows.Forms.Panel();
            this.textBox_Port = new System.Windows.Forms.TextBox();
            this.label_Port = new System.Windows.Forms.Label();
            this.button_Connect = new System.Windows.Forms.Button();
            this.panel_Connect = new System.Windows.Forms.Panel();
            this.panel_Login = new System.Windows.Forms.Panel();
            this.button_Disconnect = new System.Windows.Forms.Button();
            this.button_Login = new System.Windows.Forms.Button();
            this.panel_Project_View = new System.Windows.Forms.Panel();
            this.button_Leave_Project = new System.Windows.Forms.Button();
            this.button_Logout = new System.Windows.Forms.Button();
            this.textBox_log = new System.Windows.Forms.TextBox();
            this.button_Calender = new System.Windows.Forms.Button();
            this.button_Project_Open = new System.Windows.Forms.Button();
            this.listView_ProjectList = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button_Join_Project = new System.Windows.Forms.Button();
            this.button_Create_Project = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_Project_File_View = new System.Windows.Forms.Panel();
            this.button_File_UpLoad = new System.Windows.Forms.Button();
            this.button_Path_Select = new System.Windows.Forms.Button();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.button_Back_View = new System.Windows.Forms.Button();
            this.listView_File_List = new System.Windows.Forms.ListView();
            this.button_Open = new System.Windows.Forms.Button();
            this.panel_Down_Path = new System.Windows.Forms.Panel();
            this.textBox_File_Down_Path = new System.Windows.Forms.TextBox();
            this.label_File_Down_Path = new System.Windows.Forms.Label();
            this.button_File_DownLoad = new System.Windows.Forms.Button();
            this.panel_File_View = new System.Windows.Forms.Panel();
            this.button_Exit = new System.Windows.Forms.Button();
            this.textBox_Open_File_txt = new System.Windows.Forms.TextBox();
            this.folder_Browser_Dialog = new System.Windows.Forms.FolderBrowserDialog();
            this.open_File_Dialog = new System.Windows.Forms.OpenFileDialog();
            this.panel_ID.SuspendLayout();
            this.panel_PW.SuspendLayout();
            this.panel_IP.SuspendLayout();
            this.panel_Port.SuspendLayout();
            this.panel_Connect.SuspendLayout();
            this.panel_Login.SuspendLayout();
            this.panel_Project_View.SuspendLayout();
            this.panel_Project_File_View.SuspendLayout();
            this.panel_Down_Path.SuspendLayout();
            this.panel_File_View.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_ID
            // 
            this.panel_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_ID.Controls.Add(this.textBox_ID);
            this.panel_ID.Location = new System.Drawing.Point(32, 13);
            this.panel_ID.Name = "panel_ID";
            this.panel_ID.Size = new System.Drawing.Size(190, 34);
            this.panel_ID.TabIndex = 0;
            // 
            // textBox_ID
            // 
            this.textBox_ID.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ID.Location = new System.Drawing.Point(12, 3);
            this.textBox_ID.MaxLength = 30;
            this.textBox_ID.Multiline = true;
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(150, 31);
            this.textBox_ID.TabIndex = 1;
            // 
            // label_ID
            // 
            this.label_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_ID.AutoSize = true;
            this.label_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ID.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label_ID.Location = new System.Drawing.Point(3, 16);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(28, 20);
            this.label_ID.TabIndex = 0;
            this.label_ID.Text = "ID";
            this.label_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_PW
            // 
            this.panel_PW.Controls.Add(this.textBox_PW);
            this.panel_PW.Location = new System.Drawing.Point(32, 54);
            this.panel_PW.Name = "panel_PW";
            this.panel_PW.Size = new System.Drawing.Size(190, 36);
            this.panel_PW.TabIndex = 1;
            // 
            // textBox_PW
            // 
            this.textBox_PW.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox_PW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_PW.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_PW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PW.Location = new System.Drawing.Point(12, 3);
            this.textBox_PW.MaxLength = 30;
            this.textBox_PW.Multiline = true;
            this.textBox_PW.Name = "textBox_PW";
            this.textBox_PW.Size = new System.Drawing.Size(151, 30);
            this.textBox_PW.TabIndex = 2;
            // 
            // label_PW
            // 
            this.label_PW.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_PW.AutoSize = true;
            this.label_PW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PW.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label_PW.Location = new System.Drawing.Point(-5, 54);
            this.label_PW.Name = "label_PW";
            this.label_PW.Size = new System.Drawing.Size(36, 20);
            this.label_PW.TabIndex = 1;
            this.label_PW.Text = "PW";
            // 
            // panel_IP
            // 
            this.panel_IP.Controls.Add(this.textBox_IP);
            this.panel_IP.Location = new System.Drawing.Point(56, 22);
            this.panel_IP.Name = "panel_IP";
            this.panel_IP.Size = new System.Drawing.Size(178, 25);
            this.panel_IP.TabIndex = 2;
            // 
            // textBox_IP
            // 
            this.textBox_IP.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox_IP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_IP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_IP.Location = new System.Drawing.Point(0, 0);
            this.textBox_IP.MaxLength = 16;
            this.textBox_IP.Multiline = true;
            this.textBox_IP.Name = "textBox_IP";
            this.textBox_IP.Size = new System.Drawing.Size(140, 25);
            this.textBox_IP.TabIndex = 3;
            // 
            // label_IP
            // 
            this.label_IP.AutoSize = true;
            this.label_IP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_IP.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label_IP.Location = new System.Drawing.Point(24, 22);
            this.label_IP.Name = "label_IP";
            this.label_IP.Size = new System.Drawing.Size(26, 20);
            this.label_IP.TabIndex = 2;
            this.label_IP.Text = "IP";
            this.label_IP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_Port
            // 
            this.panel_Port.Controls.Add(this.textBox_Port);
            this.panel_Port.Location = new System.Drawing.Point(56, 63);
            this.panel_Port.Name = "panel_Port";
            this.panel_Port.Size = new System.Drawing.Size(160, 25);
            this.panel_Port.TabIndex = 2;
            // 
            // textBox_Port
            // 
            this.textBox_Port.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox_Port.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Port.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Port.Location = new System.Drawing.Point(0, 0);
            this.textBox_Port.MaxLength = 4;
            this.textBox_Port.Multiline = true;
            this.textBox_Port.Name = "textBox_Port";
            this.textBox_Port.Size = new System.Drawing.Size(140, 25);
            this.textBox_Port.TabIndex = 4;
            // 
            // label_Port
            // 
            this.label_Port.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Port.AutoSize = true;
            this.label_Port.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Port.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label_Port.Location = new System.Drawing.Point(4, 63);
            this.label_Port.Name = "label_Port";
            this.label_Port.Size = new System.Drawing.Size(42, 20);
            this.label_Port.TabIndex = 3;
            this.label_Port.Text = "Port";
            // 
            // button_Connect
            // 
            this.button_Connect.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_Connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Connect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Connect.Location = new System.Drawing.Point(-1, 106);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(249, 33);
            this.button_Connect.TabIndex = 3;
            this.button_Connect.Text = "CONNECT";
            this.button_Connect.UseVisualStyleBackColor = false;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // panel_Connect
            // 
            this.panel_Connect.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel_Connect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Connect.Controls.Add(this.panel_IP);
            this.panel_Connect.Controls.Add(this.label_Port);
            this.panel_Connect.Controls.Add(this.label_IP);
            this.panel_Connect.Controls.Add(this.panel_Port);
            this.panel_Connect.Controls.Add(this.button_Connect);
            this.panel_Connect.Location = new System.Drawing.Point(12, 12);
            this.panel_Connect.Name = "panel_Connect";
            this.panel_Connect.Size = new System.Drawing.Size(250, 140);
            this.panel_Connect.TabIndex = 2;
            // 
            // panel_Login
            // 
            this.panel_Login.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel_Login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Login.Controls.Add(this.button_Disconnect);
            this.panel_Login.Controls.Add(this.label_PW);
            this.panel_Login.Controls.Add(this.label_ID);
            this.panel_Login.Controls.Add(this.button_Login);
            this.panel_Login.Controls.Add(this.panel_ID);
            this.panel_Login.Controls.Add(this.panel_PW);
            this.panel_Login.Location = new System.Drawing.Point(12, 12);
            this.panel_Login.Name = "panel_Login";
            this.panel_Login.Size = new System.Drawing.Size(250, 140);
            this.panel_Login.TabIndex = 2;
            // 
            // button_Disconnect
            // 
            this.button_Disconnect.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button_Disconnect.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.button_Disconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Disconnect.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button_Disconnect.Location = new System.Drawing.Point(126, 104);
            this.button_Disconnect.Name = "button_Disconnect";
            this.button_Disconnect.Size = new System.Drawing.Size(122, 34);
            this.button_Disconnect.TabIndex = 4;
            this.button_Disconnect.Text = "DisConnect";
            this.button_Disconnect.UseVisualStyleBackColor = false;
            this.button_Disconnect.Click += new System.EventHandler(this.button_Disconnect_Click);
            // 
            // button_Login
            // 
            this.button_Login.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_Login.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.button_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Login.Location = new System.Drawing.Point(-1, 104);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(129, 34);
            this.button_Login.TabIndex = 3;
            this.button_Login.Text = "LogIn";
            this.button_Login.UseVisualStyleBackColor = false;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // panel_Project_View
            // 
            this.panel_Project_View.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_Project_View.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Project_View.Controls.Add(this.button_Leave_Project);
            this.panel_Project_View.Controls.Add(this.button_Logout);
            this.panel_Project_View.Controls.Add(this.textBox_log);
            this.panel_Project_View.Controls.Add(this.button_Calender);
            this.panel_Project_View.Controls.Add(this.button_Project_Open);
            this.panel_Project_View.Controls.Add(this.listView_ProjectList);
            this.panel_Project_View.Controls.Add(this.button_Join_Project);
            this.panel_Project_View.Controls.Add(this.button_Create_Project);
            this.panel_Project_View.Location = new System.Drawing.Point(10, 10);
            this.panel_Project_View.Name = "panel_Project_View";
            this.panel_Project_View.Size = new System.Drawing.Size(460, 370);
            this.panel_Project_View.TabIndex = 3;
            // 
            // button_Leave_Project
            // 
            this.button_Leave_Project.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Leave_Project.BackgroundImage = global::Project_Client.Properties.Resources.exit;
            this.button_Leave_Project.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Leave_Project.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Leave_Project.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Leave_Project.Location = new System.Drawing.Point(397, 328);
            this.button_Leave_Project.Name = "button_Leave_Project";
            this.button_Leave_Project.Size = new System.Drawing.Size(61, 40);
            this.button_Leave_Project.TabIndex = 10;
            this.button_Leave_Project.UseVisualStyleBackColor = false;
            this.button_Leave_Project.Click += new System.EventHandler(this.button_Leave_Project_Click);
            // 
            // button_Logout
            // 
            this.button_Logout.BackColor = System.Drawing.Color.RosyBrown;
            this.button_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Logout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_Logout.Location = new System.Drawing.Point(317, 328);
            this.button_Logout.Name = "button_Logout";
            this.button_Logout.Size = new System.Drawing.Size(60, 40);
            this.button_Logout.TabIndex = 9;
            this.button_Logout.Text = "Log\r\nout";
            this.button_Logout.UseVisualStyleBackColor = false;
            this.button_Logout.Click += new System.EventHandler(this.button_Logout_Click);
            // 
            // textBox_log
            // 
            this.textBox_log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_log.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_log.Location = new System.Drawing.Point(-1, -1);
            this.textBox_log.Multiline = true;
            this.textBox_log.Name = "textBox_log";
            this.textBox_log.Size = new System.Drawing.Size(399, 58);
            this.textBox_log.TabIndex = 4;
            // 
            // button_Calender
            // 
            this.button_Calender.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Calender.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Calender.BackgroundImage")));
            this.button_Calender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Calender.Location = new System.Drawing.Point(397, -1);
            this.button_Calender.Name = "button_Calender";
            this.button_Calender.Size = new System.Drawing.Size(61, 58);
            this.button_Calender.TabIndex = 1;
            this.button_Calender.UseVisualStyleBackColor = false;
            this.button_Calender.Click += new System.EventHandler(this.button_Calender_Click);
            // 
            // button_Project_Open
            // 
            this.button_Project_Open.BackgroundImage = global::Project_Client.Properties.Resources.open;
            this.button_Project_Open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Project_Open.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Project_Open.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_Project_Open.Location = new System.Drawing.Point(58, 328);
            this.button_Project_Open.Name = "button_Project_Open";
            this.button_Project_Open.Size = new System.Drawing.Size(53, 40);
            this.button_Project_Open.TabIndex = 3;
            this.button_Project_Open.UseVisualStyleBackColor = true;
            this.button_Project_Open.Click += new System.EventHandler(this.button_Project_Open_Click);
            // 
            // listView_ProjectList
            // 
            this.listView_ProjectList.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listView_ProjectList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_ProjectList.LargeImageList = this.imageList1;
            this.listView_ProjectList.Location = new System.Drawing.Point(-1, 57);
            this.listView_ProjectList.MultiSelect = false;
            this.listView_ProjectList.Name = "listView_ProjectList";
            this.listView_ProjectList.Size = new System.Drawing.Size(459, 271);
            this.listView_ProjectList.TabIndex = 0;
            this.listView_ProjectList.TileSize = new System.Drawing.Size(210, 100);
            this.listView_ProjectList.UseCompatibleStateImageBehavior = false;
            this.listView_ProjectList.View = System.Windows.Forms.View.Details;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "img_Hwp.png");
            this.imageList1.Images.SetKeyName(1, "img_Mp3.png");
            this.imageList1.Images.SetKeyName(2, "img_Txt.png");
            this.imageList1.Images.SetKeyName(3, "project-icon.png");
            // 
            // button_Join_Project
            // 
            this.button_Join_Project.BackgroundImage = global::Project_Client.Properties.Resources.join;
            this.button_Join_Project.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Join_Project.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Join_Project.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_Join_Project.Location = new System.Drawing.Point(128, 329);
            this.button_Join_Project.Name = "button_Join_Project";
            this.button_Join_Project.Size = new System.Drawing.Size(54, 40);
            this.button_Join_Project.TabIndex = 2;
            this.button_Join_Project.UseVisualStyleBackColor = true;
            this.button_Join_Project.Click += new System.EventHandler(this.button_Join_Project_Click);
            // 
            // button_Create_Project
            // 
            this.button_Create_Project.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Create_Project.BackgroundImage")));
            this.button_Create_Project.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Create_Project.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Create_Project.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button_Create_Project.Location = new System.Drawing.Point(-1, 328);
            this.button_Create_Project.Name = "button_Create_Project";
            this.button_Create_Project.Size = new System.Drawing.Size(53, 41);
            this.button_Create_Project.TabIndex = 1;
            this.button_Create_Project.UseVisualStyleBackColor = true;
            this.button_Create_Project.Click += new System.EventHandler(this.button_Create_Project_Click);
            // 
            // panel_Project_File_View
            // 
            this.panel_Project_File_View.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_Project_File_View.Controls.Add(this.button_File_UpLoad);
            this.panel_Project_File_View.Controls.Add(this.button_Path_Select);
            this.panel_Project_File_View.Controls.Add(this.button_Refresh);
            this.panel_Project_File_View.Controls.Add(this.button_Back_View);
            this.panel_Project_File_View.Controls.Add(this.listView_File_List);
            this.panel_Project_File_View.Controls.Add(this.button_Open);
            this.panel_Project_File_View.Controls.Add(this.panel_Down_Path);
            this.panel_Project_File_View.Controls.Add(this.button_File_DownLoad);
            this.panel_Project_File_View.Location = new System.Drawing.Point(10, 10);
            this.panel_Project_File_View.Name = "panel_Project_File_View";
            this.panel_Project_File_View.Size = new System.Drawing.Size(460, 370);
            this.panel_Project_File_View.TabIndex = 0;
            // 
            // button_File_UpLoad
            // 
            this.button_File_UpLoad.BackgroundImage = global::Project_Client.Properties.Resources.up;
            this.button_File_UpLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_File_UpLoad.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_File_UpLoad.Location = new System.Drawing.Point(116, -1);
            this.button_File_UpLoad.Name = "button_File_UpLoad";
            this.button_File_UpLoad.Size = new System.Drawing.Size(51, 42);
            this.button_File_UpLoad.TabIndex = 9;
            this.button_File_UpLoad.UseVisualStyleBackColor = true;
            this.button_File_UpLoad.Click += new System.EventHandler(this.button_File_UpLoad_Click);
            // 
            // button_Path_Select
            // 
            this.button_Path_Select.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_Path_Select.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Path_Select.ForeColor = System.Drawing.SystemColors.Window;
            this.button_Path_Select.Location = new System.Drawing.Point(378, 331);
            this.button_Path_Select.Name = "button_Path_Select";
            this.button_Path_Select.Size = new System.Drawing.Size(83, 38);
            this.button_Path_Select.TabIndex = 8;
            this.button_Path_Select.Text = "Find Path";
            this.button_Path_Select.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_Path_Select.UseVisualStyleBackColor = false;
            this.button_Path_Select.Click += new System.EventHandler(this.button_Path_Select_Click);
            // 
            // button_Refresh
            // 
            this.button_Refresh.BackgroundImage = global::Project_Client.Properties.Resources.refresh;
            this.button_Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Refresh.Location = new System.Drawing.Point(172, 0);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(51, 42);
            this.button_Refresh.TabIndex = 7;
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // button_Back_View
            // 
            this.button_Back_View.BackgroundImage = global::Project_Client.Properties.Resources.previous;
            this.button_Back_View.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Back_View.Location = new System.Drawing.Point(228, -1);
            this.button_Back_View.Name = "button_Back_View";
            this.button_Back_View.Size = new System.Drawing.Size(43, 42);
            this.button_Back_View.TabIndex = 6;
            this.button_Back_View.UseVisualStyleBackColor = true;
            this.button_Back_View.Click += new System.EventHandler(this.button_Back_View_Click);
            // 
            // listView_File_List
            // 
            this.listView_File_List.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listView_File_List.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_File_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_File_List.LargeImageList = this.imageList1;
            this.listView_File_List.Location = new System.Drawing.Point(0, 42);
            this.listView_File_List.MultiSelect = false;
            this.listView_File_List.Name = "listView_File_List";
            this.listView_File_List.Size = new System.Drawing.Size(461, 289);
            this.listView_File_List.TabIndex = 5;
            this.listView_File_List.TileSize = new System.Drawing.Size(210, 100);
            this.listView_File_List.UseCompatibleStateImageBehavior = false;
            this.listView_File_List.View = System.Windows.Forms.View.Tile;
            // 
            // button_Open
            // 
            this.button_Open.BackgroundImage = global::Project_Client.Properties.Resources.open;
            this.button_Open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Open.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_Open.Location = new System.Drawing.Point(0, 1);
            this.button_Open.Name = "button_Open";
            this.button_Open.Size = new System.Drawing.Size(54, 42);
            this.button_Open.TabIndex = 4;
            this.button_Open.UseVisualStyleBackColor = true;
            this.button_Open.Click += new System.EventHandler(this.button_Open_Click);
            // 
            // panel_Down_Path
            // 
            this.panel_Down_Path.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel_Down_Path.Controls.Add(this.textBox_File_Down_Path);
            this.panel_Down_Path.Controls.Add(this.label_File_Down_Path);
            this.panel_Down_Path.Location = new System.Drawing.Point(0, 331);
            this.panel_Down_Path.Name = "panel_Down_Path";
            this.panel_Down_Path.Size = new System.Drawing.Size(379, 39);
            this.panel_Down_Path.TabIndex = 3;
            // 
            // textBox_File_Down_Path
            // 
            this.textBox_File_Down_Path.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_File_Down_Path.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_File_Down_Path.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_File_Down_Path.Location = new System.Drawing.Point(100, 8);
            this.textBox_File_Down_Path.Multiline = true;
            this.textBox_File_Down_Path.Name = "textBox_File_Down_Path";
            this.textBox_File_Down_Path.ReadOnly = true;
            this.textBox_File_Down_Path.Size = new System.Drawing.Size(266, 26);
            this.textBox_File_Down_Path.TabIndex = 2;
            // 
            // label_File_Down_Path
            // 
            this.label_File_Down_Path.AutoSize = true;
            this.label_File_Down_Path.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_File_Down_Path.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_File_Down_Path.Location = new System.Drawing.Point(3, 10);
            this.label_File_Down_Path.Name = "label_File_Down_Path";
            this.label_File_Down_Path.Size = new System.Drawing.Size(89, 17);
            this.label_File_Down_Path.TabIndex = 1;
            this.label_File_Down_Path.Text = "Down_Path";
            // 
            // button_File_DownLoad
            // 
            this.button_File_DownLoad.BackgroundImage = global::Project_Client.Properties.Resources.down;
            this.button_File_DownLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_File_DownLoad.Location = new System.Drawing.Point(60, 0);
            this.button_File_DownLoad.Name = "button_File_DownLoad";
            this.button_File_DownLoad.Size = new System.Drawing.Size(51, 43);
            this.button_File_DownLoad.TabIndex = 0;
            this.button_File_DownLoad.UseVisualStyleBackColor = true;
            this.button_File_DownLoad.Click += new System.EventHandler(this.button_File_DownLoad_Click);
            // 
            // panel_File_View
            // 
            this.panel_File_View.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_File_View.Controls.Add(this.button_Exit);
            this.panel_File_View.Controls.Add(this.textBox_Open_File_txt);
            this.panel_File_View.Location = new System.Drawing.Point(10, 10);
            this.panel_File_View.Name = "panel_File_View";
            this.panel_File_View.Size = new System.Drawing.Size(460, 370);
            this.panel_File_View.TabIndex = 4;
            // 
            // button_Exit
            // 
            this.button_Exit.BackgroundImage = global::Project_Client.Properties.Resources.exit;
            this.button_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Exit.Location = new System.Drawing.Point(401, 331);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(60, 38);
            this.button_Exit.TabIndex = 6;
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // textBox_Open_File_txt
            // 
            this.textBox_Open_File_txt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox_Open_File_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Open_File_txt.Location = new System.Drawing.Point(3, 0);
            this.textBox_Open_File_txt.Multiline = true;
            this.textBox_Open_File_txt.Name = "textBox_Open_File_txt";
            this.textBox_Open_File_txt.ReadOnly = true;
            this.textBox_Open_File_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Open_File_txt.Size = new System.Drawing.Size(457, 332);
            this.textBox_Open_File_txt.TabIndex = 5;
            // 
            // open_File_Dialog
            // 
            this.open_File_Dialog.FileName = "openFileDialog1";
            // 
            // Form_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(484, 392);
            this.Controls.Add(this.panel_File_View);
            this.Controls.Add(this.panel_Project_File_View);
            this.Controls.Add(this.panel_Project_View);
            this.Controls.Add(this.panel_Login);
            this.Controls.Add(this.panel_Connect);
            this.Name = "Form_Client";
            this.Text = "Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Client_FormClosed);
            this.Load += new System.EventHandler(this.Form_Client_Load);
            this.panel_ID.ResumeLayout(false);
            this.panel_ID.PerformLayout();
            this.panel_PW.ResumeLayout(false);
            this.panel_PW.PerformLayout();
            this.panel_IP.ResumeLayout(false);
            this.panel_IP.PerformLayout();
            this.panel_Port.ResumeLayout(false);
            this.panel_Port.PerformLayout();
            this.panel_Connect.ResumeLayout(false);
            this.panel_Connect.PerformLayout();
            this.panel_Login.ResumeLayout(false);
            this.panel_Login.PerformLayout();
            this.panel_Project_View.ResumeLayout(false);
            this.panel_Project_View.PerformLayout();
            this.panel_Project_File_View.ResumeLayout(false);
            this.panel_Down_Path.ResumeLayout(false);
            this.panel_Down_Path.PerformLayout();
            this.panel_File_View.ResumeLayout(false);
            this.panel_File_View.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_ID;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Panel panel_PW;
        private System.Windows.Forms.TextBox textBox_PW;
        private System.Windows.Forms.Label label_PW;
        private System.Windows.Forms.Panel panel_IP;
        private System.Windows.Forms.TextBox textBox_IP;
        private System.Windows.Forms.Label label_IP;
        private System.Windows.Forms.Panel panel_Port;
        private System.Windows.Forms.TextBox textBox_Port;
        private System.Windows.Forms.Label label_Port;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.Panel panel_Connect;
        private System.Windows.Forms.Panel panel_Login;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.Panel panel_Project_View;
        private System.Windows.Forms.ListView listView_ProjectList;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button_Calender;
        private System.Windows.Forms.Button button_Join_Project;
        private System.Windows.Forms.Button button_Create_Project;
        private System.Windows.Forms.Button button_Project_Open;
        private System.Windows.Forms.TextBox textBox_log;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel_Project_File_View;
        private System.Windows.Forms.Button button_Open;
        private System.Windows.Forms.Panel panel_Down_Path;
        private System.Windows.Forms.TextBox textBox_File_Down_Path;
        private System.Windows.Forms.Label label_File_Down_Path;
        private System.Windows.Forms.Button button_File_DownLoad;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.Button button_Back_View;
        private System.Windows.Forms.ListView listView_File_List;
        private System.Windows.Forms.Panel panel_File_View;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.TextBox textBox_Open_File_txt;
        private System.Windows.Forms.Button button_Path_Select;
        private System.Windows.Forms.FolderBrowserDialog folder_Browser_Dialog;
        private System.Windows.Forms.Button button_Logout;
        private System.Windows.Forms.Button button_Disconnect;
        private System.Windows.Forms.Button button_Leave_Project;
        private System.Windows.Forms.Button button_File_UpLoad;
        private System.Windows.Forms.OpenFileDialog open_File_Dialog;
        private System.Windows.Forms.TextBox textBox_ID;
    }
}

