namespace Project_Server
{
    partial class Form_Server
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
            this.panel_Sever_IP = new System.Windows.Forms.Panel();
            this.textBox_IP = new System.Windows.Forms.TextBox();
            this.label_IP = new System.Windows.Forms.Label();
            this.panel_Sever_Port = new System.Windows.Forms.Panel();
            this.textBox_Port = new System.Windows.Forms.TextBox();
            this.label_Port = new System.Windows.Forms.Label();
            this.button_Server_Start = new System.Windows.Forms.Button();
            this.panel_Server_Log = new System.Windows.Forms.Panel();
            this.label_Down_UP_Load_Log = new System.Windows.Forms.Label();
            this.textBox_Down_Up_Load_Log = new System.Windows.Forms.TextBox();
            this.label_Server_Status = new System.Windows.Forms.Label();
            this.panel_Connect_Log = new System.Windows.Forms.Panel();
            this.listView_Client_List = new System.Windows.Forms.ListView();
            this.label_Client_List = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_Storage_Path = new System.Windows.Forms.TextBox();
            this.label_Storage_Path = new System.Windows.Forms.Label();
            this.button_Find_Path = new System.Windows.Forms.Button();
            this.folder_Browser_Dialog = new System.Windows.Forms.FolderBrowserDialog();
            this.panel_Sever_IP.SuspendLayout();
            this.panel_Sever_Port.SuspendLayout();
            this.panel_Server_Log.SuspendLayout();
            this.panel_Connect_Log.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Sever_IP
            // 
            this.panel_Sever_IP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Sever_IP.Controls.Add(this.textBox_IP);
            this.panel_Sever_IP.Controls.Add(this.label_IP);
            this.panel_Sever_IP.Location = new System.Drawing.Point(12, 12);
            this.panel_Sever_IP.Name = "panel_Sever_IP";
            this.panel_Sever_IP.Size = new System.Drawing.Size(321, 24);
            this.panel_Sever_IP.TabIndex = 2;
            // 
            // textBox_IP
            // 
            this.textBox_IP.Location = new System.Drawing.Point(24, 0);
            this.textBox_IP.Name = "textBox_IP";
            this.textBox_IP.Size = new System.Drawing.Size(294, 21);
            this.textBox_IP.TabIndex = 1;
            // 
            // label_IP
            // 
            this.label_IP.AutoSize = true;
            this.label_IP.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_IP.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_IP.Location = new System.Drawing.Point(0, 0);
            this.label_IP.Name = "label_IP";
            this.label_IP.Size = new System.Drawing.Size(24, 15);
            this.label_IP.TabIndex = 0;
            this.label_IP.Text = "IP :";
            // 
            // panel_Sever_Port
            // 
            this.panel_Sever_Port.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Sever_Port.Controls.Add(this.textBox_Port);
            this.panel_Sever_Port.Controls.Add(this.label_Port);
            this.panel_Sever_Port.Location = new System.Drawing.Point(339, 12);
            this.panel_Sever_Port.Name = "panel_Sever_Port";
            this.panel_Sever_Port.Size = new System.Drawing.Size(201, 24);
            this.panel_Sever_Port.TabIndex = 3;
            // 
            // textBox_Port
            // 
            this.textBox_Port.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Port.Location = new System.Drawing.Point(36, 0);
            this.textBox_Port.Name = "textBox_Port";
            this.textBox_Port.Size = new System.Drawing.Size(162, 21);
            this.textBox_Port.TabIndex = 1;
            // 
            // label_Port
            // 
            this.label_Port.AutoSize = true;
            this.label_Port.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_Port.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_Port.Location = new System.Drawing.Point(0, 0);
            this.label_Port.Name = "label_Port";
            this.label_Port.Size = new System.Drawing.Size(36, 15);
            this.label_Port.TabIndex = 0;
            this.label_Port.Text = "Port :";
            // 
            // button_Server_Start
            // 
            this.button_Server_Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Server_Start.Location = new System.Drawing.Point(546, 13);
            this.button_Server_Start.Name = "button_Server_Start";
            this.button_Server_Start.Size = new System.Drawing.Size(125, 23);
            this.button_Server_Start.TabIndex = 4;
            this.button_Server_Start.Text = "Start";
            this.button_Server_Start.UseVisualStyleBackColor = true;
            this.button_Server_Start.Click += new System.EventHandler(this.button_Server_Start_Click);
            // 
            // panel_Server_Log
            // 
            this.panel_Server_Log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Server_Log.Controls.Add(this.label_Down_UP_Load_Log);
            this.panel_Server_Log.Controls.Add(this.textBox_Down_Up_Load_Log);
            this.panel_Server_Log.Location = new System.Drawing.Point(15, 91);
            this.panel_Server_Log.Name = "panel_Server_Log";
            this.panel_Server_Log.Size = new System.Drawing.Size(318, 286);
            this.panel_Server_Log.TabIndex = 5;
            // 
            // label_Down_UP_Load_Log
            // 
            this.label_Down_UP_Load_Log.AutoSize = true;
            this.label_Down_UP_Load_Log.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Down_UP_Load_Log.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_Down_UP_Load_Log.Location = new System.Drawing.Point(0, 0);
            this.label_Down_UP_Load_Log.Name = "label_Down_UP_Load_Log";
            this.label_Down_UP_Load_Log.Size = new System.Drawing.Size(131, 12);
            this.label_Down_UP_Load_Log.TabIndex = 7;
            this.label_Down_UP_Load_Log.Text = "Down-Up Load Log";
            // 
            // textBox_Down_Up_Load_Log
            // 
            this.textBox_Down_Up_Load_Log.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_Down_Up_Load_Log.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox_Down_Up_Load_Log.Location = new System.Drawing.Point(0, 15);
            this.textBox_Down_Up_Load_Log.Multiline = true;
            this.textBox_Down_Up_Load_Log.Name = "textBox_Down_Up_Load_Log";
            this.textBox_Down_Up_Load_Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Down_Up_Load_Log.Size = new System.Drawing.Size(318, 271);
            this.textBox_Down_Up_Load_Log.TabIndex = 0;
            this.textBox_Down_Up_Load_Log.TabStop = false;
            // 
            // label_Server_Status
            // 
            this.label_Server_Status.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Server_Status.AutoSize = true;
            this.label_Server_Status.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_Server_Status.ForeColor = System.Drawing.Color.Red;
            this.label_Server_Status.Location = new System.Drawing.Point(586, 49);
            this.label_Server_Status.Name = "label_Server_Status";
            this.label_Server_Status.Size = new System.Drawing.Size(85, 12);
            this.label_Server_Status.TabIndex = 8;
            this.label_Server_Status.Text = "Not Running";
            // 
            // panel_Connect_Log
            // 
            this.panel_Connect_Log.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Connect_Log.Controls.Add(this.listView_Client_List);
            this.panel_Connect_Log.Controls.Add(this.label_Client_List);
            this.panel_Connect_Log.Location = new System.Drawing.Point(339, 91);
            this.panel_Connect_Log.Name = "panel_Connect_Log";
            this.panel_Connect_Log.Size = new System.Drawing.Size(332, 286);
            this.panel_Connect_Log.TabIndex = 9;
            // 
            // listView_Client_List
            // 
            this.listView_Client_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_Client_List.Location = new System.Drawing.Point(0, 12);
            this.listView_Client_List.Name = "listView_Client_List";
            this.listView_Client_List.Size = new System.Drawing.Size(332, 274);
            this.listView_Client_List.TabIndex = 11;
            this.listView_Client_List.UseCompatibleStateImageBehavior = false;
            // 
            // label_Client_List
            // 
            this.label_Client_List.AutoSize = true;
            this.label_Client_List.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Client_List.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_Client_List.Location = new System.Drawing.Point(0, 0);
            this.label_Client_List.Name = "label_Client_List";
            this.label_Client_List.Size = new System.Drawing.Size(72, 12);
            this.label_Client_List.TabIndex = 10;
            this.label_Client_List.Text = "Client List";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_Storage_Path);
            this.panel1.Controls.Add(this.label_Storage_Path);
            this.panel1.Location = new System.Drawing.Point(12, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 24);
            this.panel1.TabIndex = 10;
            // 
            // textBox_Storage_Path
            // 
            this.textBox_Storage_Path.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBox_Storage_Path.Location = new System.Drawing.Point(47, 0);
            this.textBox_Storage_Path.Name = "textBox_Storage_Path";
            this.textBox_Storage_Path.Size = new System.Drawing.Size(440, 21);
            this.textBox_Storage_Path.TabIndex = 1;
            // 
            // label_Storage_Path
            // 
            this.label_Storage_Path.AutoSize = true;
            this.label_Storage_Path.Location = new System.Drawing.Point(3, 0);
            this.label_Storage_Path.Name = "label_Storage_Path";
            this.label_Storage_Path.Size = new System.Drawing.Size(38, 12);
            this.label_Storage_Path.TabIndex = 0;
            this.label_Storage_Path.Text = "Path :";
            // 
            // button_Find_Path
            // 
            this.button_Find_Path.BackColor = System.Drawing.SystemColors.Control;
            this.button_Find_Path.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button_Find_Path.Location = new System.Drawing.Point(505, 44);
            this.button_Find_Path.Name = "button_Find_Path";
            this.button_Find_Path.Size = new System.Drawing.Size(75, 23);
            this.button_Find_Path.TabIndex = 11;
            this.button_Find_Path.Text = "Find Path";
            this.button_Find_Path.UseVisualStyleBackColor = false;
            this.button_Find_Path.Click += new System.EventHandler(this.button_Find_Path_Click);
            // 
            // Form_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 394);
            this.Controls.Add(this.button_Find_Path);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_Connect_Log);
            this.Controls.Add(this.label_Server_Status);
            this.Controls.Add(this.panel_Server_Log);
            this.Controls.Add(this.button_Server_Start);
            this.Controls.Add(this.panel_Sever_Port);
            this.Controls.Add(this.panel_Sever_IP);
            this.Name = "Form_Server";
            this.Text = "Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Server_FormClosed);
            this.Load += new System.EventHandler(this.Form_Server_Load);
            this.panel_Sever_IP.ResumeLayout(false);
            this.panel_Sever_IP.PerformLayout();
            this.panel_Sever_Port.ResumeLayout(false);
            this.panel_Sever_Port.PerformLayout();
            this.panel_Server_Log.ResumeLayout(false);
            this.panel_Server_Log.PerformLayout();
            this.panel_Connect_Log.ResumeLayout(false);
            this.panel_Connect_Log.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Sever_IP;
        private System.Windows.Forms.TextBox textBox_IP;
        private System.Windows.Forms.Label label_IP;
        private System.Windows.Forms.Panel panel_Sever_Port;
        private System.Windows.Forms.TextBox textBox_Port;
        private System.Windows.Forms.Label label_Port;
        private System.Windows.Forms.Button button_Server_Start;
        private System.Windows.Forms.Panel panel_Server_Log;
        private System.Windows.Forms.TextBox textBox_Down_Up_Load_Log;
        private System.Windows.Forms.Label label_Down_UP_Load_Log;
        private System.Windows.Forms.Label label_Server_Status;
        private System.Windows.Forms.Panel panel_Connect_Log;
        private System.Windows.Forms.Label label_Client_List;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_Storage_Path;
        private System.Windows.Forms.TextBox textBox_Storage_Path;
        private System.Windows.Forms.Button button_Find_Path;
        private System.Windows.Forms.FolderBrowserDialog folder_Browser_Dialog;
        private System.Windows.Forms.ListView listView_Client_List;
    }
}

