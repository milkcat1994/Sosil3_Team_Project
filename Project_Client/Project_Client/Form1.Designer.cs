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
            this.button_Login = new System.Windows.Forms.Button();
            this.panel_Project_View = new System.Windows.Forms.Panel();
            this.textBox_log = new System.Windows.Forms.TextBox();
            this.button_Calender = new System.Windows.Forms.Button();
            this.button_Project_Open = new System.Windows.Forms.Button();
            this.listView_Project_1 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button_Delete_Project = new System.Windows.Forms.Button();
            this.button_Create_Project = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_Project_File_View = new System.Windows.Forms.Panel();
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_Path_Select = new System.Windows.Forms.Button();
            this.folder_Browser_Dialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
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
            this.panel_ID.Controls.Add(this.textBox_ID);
            this.panel_ID.Controls.Add(this.label_ID);
            this.panel_ID.Location = new System.Drawing.Point(36, 19);
            this.panel_ID.Name = "panel_ID";
            this.panel_ID.Size = new System.Drawing.Size(171, 25);
            this.panel_ID.TabIndex = 0;
            // 
            // textBox_ID
            // 
            this.textBox_ID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_ID.Location = new System.Drawing.Point(24, 0);
            this.textBox_ID.MaxLength = 30;
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(147, 21);
            this.textBox_ID.TabIndex = 1;
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_ID.Location = new System.Drawing.Point(0, 0);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(24, 12);
            this.label_ID.TabIndex = 0;
            this.label_ID.Text = "ID :";
            // 
            // panel_PW
            // 
            this.panel_PW.Controls.Add(this.textBox_PW);
            this.panel_PW.Controls.Add(this.label_PW);
            this.panel_PW.Location = new System.Drawing.Point(36, 63);
            this.panel_PW.Name = "panel_PW";
            this.panel_PW.Size = new System.Drawing.Size(171, 25);
            this.panel_PW.TabIndex = 1;
            // 
            // textBox_PW
            // 
            this.textBox_PW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_PW.Location = new System.Drawing.Point(31, 0);
            this.textBox_PW.MaxLength = 30;
            this.textBox_PW.Name = "textBox_PW";
            this.textBox_PW.Size = new System.Drawing.Size(140, 21);
            this.textBox_PW.TabIndex = 2;
            // 
            // label_PW
            // 
            this.label_PW.AutoSize = true;
            this.label_PW.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_PW.Location = new System.Drawing.Point(0, 0);
            this.label_PW.Name = "label_PW";
            this.label_PW.Size = new System.Drawing.Size(31, 12);
            this.label_PW.TabIndex = 1;
            this.label_PW.Text = "PW :";
            // 
            // panel_IP
            // 
            this.panel_IP.Controls.Add(this.textBox_IP);
            this.panel_IP.Controls.Add(this.label_IP);
            this.panel_IP.Location = new System.Drawing.Point(32, 19);
            this.panel_IP.Name = "panel_IP";
            this.panel_IP.Size = new System.Drawing.Size(196, 25);
            this.panel_IP.TabIndex = 2;
            // 
            // textBox_IP
            // 
            this.textBox_IP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_IP.Location = new System.Drawing.Point(24, 0);
            this.textBox_IP.MaxLength = 16;
            this.textBox_IP.Name = "textBox_IP";
            this.textBox_IP.Size = new System.Drawing.Size(172, 21);
            this.textBox_IP.TabIndex = 3;
            // 
            // label_IP
            // 
            this.label_IP.AutoSize = true;
            this.label_IP.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_IP.Location = new System.Drawing.Point(0, 0);
            this.label_IP.Name = "label_IP";
            this.label_IP.Size = new System.Drawing.Size(24, 12);
            this.label_IP.TabIndex = 2;
            this.label_IP.Text = "IP :";
            // 
            // panel_Port
            // 
            this.panel_Port.Controls.Add(this.textBox_Port);
            this.panel_Port.Controls.Add(this.label_Port);
            this.panel_Port.Location = new System.Drawing.Point(32, 63);
            this.panel_Port.Name = "panel_Port";
            this.panel_Port.Size = new System.Drawing.Size(194, 25);
            this.panel_Port.TabIndex = 2;
            // 
            // textBox_Port
            // 
            this.textBox_Port.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Port.Location = new System.Drawing.Point(35, 0);
            this.textBox_Port.MaxLength = 4;
            this.textBox_Port.Name = "textBox_Port";
            this.textBox_Port.Size = new System.Drawing.Size(159, 21);
            this.textBox_Port.TabIndex = 4;
            // 
            // label_Port
            // 
            this.label_Port.AutoSize = true;
            this.label_Port.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_Port.Location = new System.Drawing.Point(0, 0);
            this.label_Port.Name = "label_Port";
            this.label_Port.Size = new System.Drawing.Size(35, 12);
            this.label_Port.TabIndex = 3;
            this.label_Port.Text = "Port :";
            // 
            // button_Connect
            // 
            this.button_Connect.Location = new System.Drawing.Point(153, 106);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(75, 23);
            this.button_Connect.TabIndex = 3;
            this.button_Connect.Text = "연결";
            this.button_Connect.UseVisualStyleBackColor = true;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // panel_Connect
            // 
            this.panel_Connect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Connect.Controls.Add(this.panel_IP);
            this.panel_Connect.Controls.Add(this.panel_Port);
            this.panel_Connect.Controls.Add(this.button_Connect);
            this.panel_Connect.Location = new System.Drawing.Point(12, 31);
            this.panel_Connect.Name = "panel_Connect";
            this.panel_Connect.Size = new System.Drawing.Size(250, 140);
            this.panel_Connect.TabIndex = 2;
            // 
            // panel_Login
            // 
            this.panel_Login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Login.Controls.Add(this.button_Login);
            this.panel_Login.Controls.Add(this.panel_ID);
            this.panel_Login.Controls.Add(this.panel_PW);
            this.panel_Login.Location = new System.Drawing.Point(12, 31);
            this.panel_Login.Name = "panel_Login";
            this.panel_Login.Size = new System.Drawing.Size(250, 140);
            this.panel_Login.TabIndex = 2;
            // 
            // button_Login
            // 
            this.button_Login.Location = new System.Drawing.Point(132, 106);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(75, 23);
            this.button_Login.TabIndex = 3;
            this.button_Login.Text = "로그인";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // panel_Project_View
            // 
            this.panel_Project_View.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Project_View.Controls.Add(this.textBox_log);
            this.panel_Project_View.Controls.Add(this.button_Calender);
            this.panel_Project_View.Controls.Add(this.button_Project_Open);
            this.panel_Project_View.Controls.Add(this.listView_Project_1);
            this.panel_Project_View.Controls.Add(this.button_Delete_Project);
            this.panel_Project_View.Controls.Add(this.button_Create_Project);
            this.panel_Project_View.Location = new System.Drawing.Point(12, 12);
            this.panel_Project_View.Name = "panel_Project_View";
            this.panel_Project_View.Size = new System.Drawing.Size(460, 370);
            this.panel_Project_View.TabIndex = 3;
            // 
            // textBox_log
            // 
            this.textBox_log.Location = new System.Drawing.Point(13, 240);
            this.textBox_log.Multiline = true;
            this.textBox_log.Name = "textBox_log";
            this.textBox_log.Size = new System.Drawing.Size(444, 73);
            this.textBox_log.TabIndex = 4;
            // 
            // button_Calender
            // 
            this.button_Calender.Location = new System.Drawing.Point(382, 3);
            this.button_Calender.Name = "button_Calender";
            this.button_Calender.Size = new System.Drawing.Size(75, 23);
            this.button_Calender.TabIndex = 1;
            this.button_Calender.Text = "달력";
            this.button_Calender.UseVisualStyleBackColor = true;
            // 
            // button_Project_Open
            // 
            this.button_Project_Open.Location = new System.Drawing.Point(172, 319);
            this.button_Project_Open.Name = "button_Project_Open";
            this.button_Project_Open.Size = new System.Drawing.Size(108, 38);
            this.button_Project_Open.TabIndex = 3;
            this.button_Project_Open.Text = "프로젝트 열기";
            this.button_Project_Open.UseVisualStyleBackColor = true;
            this.button_Project_Open.Click += new System.EventHandler(this.button_Project_Open_Click);
            // 
            // listView_Project_1
            // 
            this.listView_Project_1.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listView_Project_1.LargeImageList = this.imageList1;
            this.listView_Project_1.Location = new System.Drawing.Point(-1, 32);
            this.listView_Project_1.MultiSelect = false;
            this.listView_Project_1.Name = "listView_Project_1";
            this.listView_Project_1.Size = new System.Drawing.Size(460, 202);
            this.listView_Project_1.TabIndex = 0;
            this.listView_Project_1.TileSize = new System.Drawing.Size(210, 100);
            this.listView_Project_1.UseCompatibleStateImageBehavior = false;
            this.listView_Project_1.View = System.Windows.Forms.View.Tile;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Play.png");
            this.imageList1.Images.SetKeyName(1, "Pause.png");
            // 
            // button_Delete_Project
            // 
            this.button_Delete_Project.Location = new System.Drawing.Point(321, 319);
            this.button_Delete_Project.Name = "button_Delete_Project";
            this.button_Delete_Project.Size = new System.Drawing.Size(108, 38);
            this.button_Delete_Project.TabIndex = 2;
            this.button_Delete_Project.Text = "프로젝트 삭제";
            this.button_Delete_Project.UseVisualStyleBackColor = true;
            // 
            // button_Create_Project
            // 
            this.button_Create_Project.Location = new System.Drawing.Point(22, 319);
            this.button_Create_Project.Name = "button_Create_Project";
            this.button_Create_Project.Size = new System.Drawing.Size(108, 38);
            this.button_Create_Project.TabIndex = 1;
            this.button_Create_Project.Text = "프로젝트 생성";
            this.button_Create_Project.UseVisualStyleBackColor = true;
            this.button_Create_Project.Click += new System.EventHandler(this.button_Create_Project_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel_Project_File_View
            // 
            this.panel_Project_File_View.Controls.Add(this.button_Path_Select);
            this.panel_Project_File_View.Controls.Add(this.button_Refresh);
            this.panel_Project_File_View.Controls.Add(this.button_Back_View);
            this.panel_Project_File_View.Controls.Add(this.listView_File_List);
            this.panel_Project_File_View.Controls.Add(this.button_Open);
            this.panel_Project_File_View.Controls.Add(this.panel_Down_Path);
            this.panel_Project_File_View.Controls.Add(this.button_File_DownLoad);
            this.panel_Project_File_View.Location = new System.Drawing.Point(12, 12);
            this.panel_Project_File_View.Name = "panel_Project_File_View";
            this.panel_Project_File_View.Size = new System.Drawing.Size(460, 370);
            this.panel_Project_File_View.TabIndex = 0;
            // 
            // button_Refresh
            // 
            this.button_Refresh.Location = new System.Drawing.Point(92, 344);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(75, 23);
            this.button_Refresh.TabIndex = 7;
            this.button_Refresh.Text = "새로고침";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // button_Back_View
            // 
            this.button_Back_View.Location = new System.Drawing.Point(4, 343);
            this.button_Back_View.Name = "button_Back_View";
            this.button_Back_View.Size = new System.Drawing.Size(75, 23);
            this.button_Back_View.TabIndex = 6;
            this.button_Back_View.Text = "이전화면";
            this.button_Back_View.UseVisualStyleBackColor = true;
            this.button_Back_View.Click += new System.EventHandler(this.button_Back_View_Click);
            // 
            // listView_File_List
            // 
            this.listView_File_List.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listView_File_List.LargeImageList = this.imageList1;
            this.listView_File_List.Location = new System.Drawing.Point(0, 0);
            this.listView_File_List.MultiSelect = false;
            this.listView_File_List.Name = "listView_File_List";
            this.listView_File_List.Size = new System.Drawing.Size(460, 286);
            this.listView_File_List.TabIndex = 5;
            this.listView_File_List.TileSize = new System.Drawing.Size(210, 100);
            this.listView_File_List.UseCompatibleStateImageBehavior = false;
            this.listView_File_List.View = System.Windows.Forms.View.Tile;
            // 
            // button_Open
            // 
            this.button_Open.Location = new System.Drawing.Point(274, 343);
            this.button_Open.Name = "button_Open";
            this.button_Open.Size = new System.Drawing.Size(75, 23);
            this.button_Open.TabIndex = 4;
            this.button_Open.Text = "File Open";
            this.button_Open.UseVisualStyleBackColor = true;
            this.button_Open.Click += new System.EventHandler(this.button_Open_Click);
            // 
            // panel_Down_Path
            // 
            this.panel_Down_Path.Controls.Add(this.textBox_File_Down_Path);
            this.panel_Down_Path.Controls.Add(this.label_File_Down_Path);
            this.panel_Down_Path.Location = new System.Drawing.Point(4, 311);
            this.panel_Down_Path.Name = "panel_Down_Path";
            this.panel_Down_Path.Size = new System.Drawing.Size(345, 26);
            this.panel_Down_Path.TabIndex = 3;
            // 
            // textBox_File_Down_Path
            // 
            this.textBox_File_Down_Path.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_File_Down_Path.Location = new System.Drawing.Point(76, 0);
            this.textBox_File_Down_Path.Name = "textBox_File_Down_Path";
            this.textBox_File_Down_Path.Size = new System.Drawing.Size(269, 21);
            this.textBox_File_Down_Path.TabIndex = 2;
            // 
            // label_File_Down_Path
            // 
            this.label_File_Down_Path.AutoSize = true;
            this.label_File_Down_Path.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_File_Down_Path.Location = new System.Drawing.Point(0, 0);
            this.label_File_Down_Path.Name = "label_File_Down_Path";
            this.label_File_Down_Path.Size = new System.Drawing.Size(76, 12);
            this.label_File_Down_Path.TabIndex = 1;
            this.label_File_Down_Path.Text = "Down_Path :";
            // 
            // button_File_DownLoad
            // 
            this.button_File_DownLoad.Location = new System.Drawing.Point(355, 344);
            this.button_File_DownLoad.Name = "button_File_DownLoad";
            this.button_File_DownLoad.Size = new System.Drawing.Size(101, 23);
            this.button_File_DownLoad.TabIndex = 0;
            this.button_File_DownLoad.Text = "File DownLoad";
            this.button_File_DownLoad.UseVisualStyleBackColor = true;
            this.button_File_DownLoad.Click += new System.EventHandler(this.button_File_DownLoad_Click);
            // 
            // panel_File_View
            // 
            this.panel_File_View.Controls.Add(this.button_Exit);
            this.panel_File_View.Controls.Add(this.textBox_Open_File_txt);
            this.panel_File_View.Location = new System.Drawing.Point(-240, 12);
            this.panel_File_View.Name = "panel_File_View";
            this.panel_File_View.Size = new System.Drawing.Size(460, 370);
            this.panel_File_View.TabIndex = 4;
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(346, 344);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(111, 23);
            this.button_Exit.TabIndex = 6;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // textBox_Open_File_txt
            // 
            this.textBox_Open_File_txt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox_Open_File_txt.Location = new System.Drawing.Point(3, 0);
            this.textBox_Open_File_txt.Multiline = true;
            this.textBox_Open_File_txt.Name = "textBox_Open_File_txt";
            this.textBox_Open_File_txt.ReadOnly = true;
            this.textBox_Open_File_txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Open_File_txt.Size = new System.Drawing.Size(457, 332);
            this.textBox_Open_File_txt.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // button_Path_Select
            // 
            this.button_Path_Select.Location = new System.Drawing.Point(356, 308);
            this.button_Path_Select.Name = "button_Path_Select";
            this.button_Path_Select.Size = new System.Drawing.Size(100, 23);
            this.button_Path_Select.TabIndex = 8;
            this.button_Path_Select.Text = "Find Path";
            this.button_Path_Select.UseVisualStyleBackColor = true;
            this.button_Path_Select.Click += new System.EventHandler(this.button_Path_Select_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            // 
            // Form_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 505);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.panel_Login.ResumeLayout(false);
            this.panel_Project_View.ResumeLayout(false);
            this.panel_Project_View.PerformLayout();
            this.panel_Project_File_View.ResumeLayout(false);
            this.panel_Down_Path.ResumeLayout(false);
            this.panel_Down_Path.PerformLayout();
            this.panel_File_View.ResumeLayout(false);
            this.panel_File_View.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_ID;
        private System.Windows.Forms.TextBox textBox_ID;
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
        private System.Windows.Forms.ListView listView_Project_1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button_Calender;
        private System.Windows.Forms.Button button_Delete_Project;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Path_Select;
        private System.Windows.Forms.FolderBrowserDialog folder_Browser_Dialog;
        private System.Windows.Forms.Label label2;
    }
}

