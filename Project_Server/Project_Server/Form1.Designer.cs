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
            this.button_Server_Start = new System.Windows.Forms.Button();
            this.panel_Sever_Port = new System.Windows.Forms.Panel();
            this.textBox_Port = new System.Windows.Forms.TextBox();
            this.label_Port = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Find_Path = new System.Windows.Forms.Button();
            this.label_Storage_Path = new System.Windows.Forms.Label();
            this.textBox_Storage_Path = new System.Windows.Forms.TextBox();
            this.label_IP = new System.Windows.Forms.Label();
            this.textBox_IP = new System.Windows.Forms.TextBox();
            this.panel_Server_Log = new System.Windows.Forms.Panel();
            this.label_Down_UP_Load_Log = new System.Windows.Forms.Label();
            this.textBox_Down_Up_Load_Log = new System.Windows.Forms.TextBox();
            this.panel_Connect_Log = new System.Windows.Forms.Panel();
            this.listView_Client_List = new System.Windows.Forms.ListView();
            this.label_Client_List = new System.Windows.Forms.Label();
            this.folder_Browser_Dialog = new System.Windows.Forms.FolderBrowserDialog();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Client_Primary_Key = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel_Sever_IP.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_Server_Log.SuspendLayout();
            this.panel_Connect_Log.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Sever_IP
            // 
            this.panel_Sever_IP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Sever_IP.BackColor = System.Drawing.Color.White;
            this.panel_Sever_IP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Sever_IP.Controls.Add(this.button_Server_Start);
            this.panel_Sever_IP.Controls.Add(this.panel_Sever_Port);
            this.panel_Sever_IP.Controls.Add(this.textBox_Port);
            this.panel_Sever_IP.Controls.Add(this.label_Port);
            this.panel_Sever_IP.Controls.Add(this.panel1);
            this.panel_Sever_IP.Controls.Add(this.label_IP);
            this.panel_Sever_IP.Controls.Add(this.textBox_IP);
            this.panel_Sever_IP.Location = new System.Drawing.Point(12, 12);
            this.panel_Sever_IP.Name = "panel_Sever_IP";
            this.panel_Sever_IP.Size = new System.Drawing.Size(644, 116);
            this.panel_Sever_IP.TabIndex = 2;
            // 
            // button_Server_Start
            // 
            this.button_Server_Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Server_Start.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_Server_Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Server_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Server_Start.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Server_Start.Location = new System.Drawing.Point(236, 0);
            this.button_Server_Start.Name = "button_Server_Start";
            this.button_Server_Start.Size = new System.Drawing.Size(132, 66);
            this.button_Server_Start.TabIndex = 4;
            this.button_Server_Start.Text = "Connect";
            this.button_Server_Start.UseVisualStyleBackColor = false;
            this.button_Server_Start.Click += new System.EventHandler(this.button_Server_Start_Click);
            // 
            // panel_Sever_Port
            // 
            this.panel_Sever_Port.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Sever_Port.BackColor = System.Drawing.Color.LavenderBlush;
            this.panel_Sever_Port.BackgroundImage = global::Project_Server.Properties.Resources.disconpic;
            this.panel_Sever_Port.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_Sever_Port.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Sever_Port.Location = new System.Drawing.Point(488, 0);
            this.panel_Sever_Port.Name = "panel_Sever_Port";
            this.panel_Sever_Port.Size = new System.Drawing.Size(155, 113);
            this.panel_Sever_Port.TabIndex = 3;
            // 
            // textBox_Port
            // 
            this.textBox_Port.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Port.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_Port.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Port.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Port.Location = new System.Drawing.Point(73, 36);
            this.textBox_Port.Multiline = true;
            this.textBox_Port.Name = "textBox_Port";
            this.textBox_Port.Size = new System.Drawing.Size(162, 25);
            this.textBox_Port.TabIndex = 1;
            // 
            // label_Port
            // 
            this.label_Port.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Port.AutoSize = true;
            this.label_Port.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Port.Location = new System.Drawing.Point(15, 36);
            this.label_Port.Name = "label_Port";
            this.label_Port.Size = new System.Drawing.Size(47, 24);
            this.label_Port.TabIndex = 0;
            this.label_Port.Text = "Port";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_Find_Path);
            this.panel1.Controls.Add(this.label_Storage_Path);
            this.panel1.Controls.Add(this.textBox_Storage_Path);
            this.panel1.Location = new System.Drawing.Point(0, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 46);
            this.panel1.TabIndex = 10;
            // 
            // button_Find_Path
            // 
            this.button_Find_Path.BackColor = System.Drawing.SystemColors.Control;
            this.button_Find_Path.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Find_Path.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button_Find_Path.Location = new System.Drawing.Point(354, 5);
            this.button_Find_Path.Name = "button_Find_Path";
            this.button_Find_Path.Size = new System.Drawing.Size(100, 38);
            this.button_Find_Path.TabIndex = 11;
            this.button_Find_Path.Text = "Find";
            this.button_Find_Path.UseVisualStyleBackColor = false;
            this.button_Find_Path.Click += new System.EventHandler(this.button_Find_Path_Click);
            // 
            // label_Storage_Path
            // 
            this.label_Storage_Path.AutoSize = true;
            this.label_Storage_Path.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Storage_Path.Location = new System.Drawing.Point(11, 8);
            this.label_Storage_Path.Name = "label_Storage_Path";
            this.label_Storage_Path.Size = new System.Drawing.Size(51, 24);
            this.label_Storage_Path.TabIndex = 0;
            this.label_Storage_Path.Text = "Path";
            // 
            // textBox_Storage_Path
            // 
            this.textBox_Storage_Path.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Storage_Path.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_Storage_Path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Storage_Path.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Storage_Path.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_Storage_Path.Location = new System.Drawing.Point(71, 5);
            this.textBox_Storage_Path.Multiline = true;
            this.textBox_Storage_Path.Name = "textBox_Storage_Path";
            this.textBox_Storage_Path.ReadOnly = true;
            this.textBox_Storage_Path.Size = new System.Drawing.Size(278, 38);
            this.textBox_Storage_Path.TabIndex = 1;
            this.textBox_Storage_Path.Text = "C:/Users/user/Documents";
            // 
            // label_IP
            // 
            this.label_IP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_IP.AutoSize = true;
            this.label_IP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_IP.Location = new System.Drawing.Point(31, 8);
            this.label_IP.Name = "label_IP";
            this.label_IP.Size = new System.Drawing.Size(34, 24);
            this.label_IP.TabIndex = 0;
            this.label_IP.Text = "IP ";
            // 
            // textBox_IP
            // 
            this.textBox_IP.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_IP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_IP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_IP.Location = new System.Drawing.Point(73, 8);
            this.textBox_IP.Multiline = true;
            this.textBox_IP.Name = "textBox_IP";
            this.textBox_IP.Size = new System.Drawing.Size(162, 28);
            this.textBox_IP.TabIndex = 1;
            // 
            // panel_Server_Log
            // 
            this.panel_Server_Log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Server_Log.Controls.Add(this.label_Down_UP_Load_Log);
            this.panel_Server_Log.Controls.Add(this.textBox_Down_Up_Load_Log);
            this.panel_Server_Log.Location = new System.Drawing.Point(12, 131);
            this.panel_Server_Log.Name = "panel_Server_Log";
            this.panel_Server_Log.Size = new System.Drawing.Size(335, 305);
            this.panel_Server_Log.TabIndex = 5;
            // 
            // label_Down_UP_Load_Log
            // 
            this.label_Down_UP_Load_Log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Down_UP_Load_Log.AutoSize = true;
            this.label_Down_UP_Load_Log.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Down_UP_Load_Log.Location = new System.Drawing.Point(-2, -2);
            this.label_Down_UP_Load_Log.Name = "label_Down_UP_Load_Log";
            this.label_Down_UP_Load_Log.Size = new System.Drawing.Size(137, 18);
            this.label_Down_UP_Load_Log.TabIndex = 7;
            this.label_Down_UP_Load_Log.Text = "Down-Up Load Log";
            // 
            // textBox_Down_Up_Load_Log
            // 
            this.textBox_Down_Up_Load_Log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Down_Up_Load_Log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Down_Up_Load_Log.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox_Down_Up_Load_Log.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Down_Up_Load_Log.Location = new System.Drawing.Point(3, 22);
            this.textBox_Down_Up_Load_Log.Multiline = true;
            this.textBox_Down_Up_Load_Log.Name = "textBox_Down_Up_Load_Log";
            this.textBox_Down_Up_Load_Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Down_Up_Load_Log.Size = new System.Drawing.Size(298, 280);
            this.textBox_Down_Up_Load_Log.TabIndex = 0;
            this.textBox_Down_Up_Load_Log.TabStop = false;
            // 
            // panel_Connect_Log
            // 
            this.panel_Connect_Log.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Connect_Log.Controls.Add(this.listView_Client_List);
            this.panel_Connect_Log.Controls.Add(this.label_Client_List);
            this.panel_Connect_Log.Location = new System.Drawing.Point(349, 131);
            this.panel_Connect_Log.Name = "panel_Connect_Log";
            this.panel_Connect_Log.Size = new System.Drawing.Size(307, 305);
            this.panel_Connect_Log.TabIndex = 9;
            // 
            // listView_Client_List
            // 
            this.listView_Client_List.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_Client_List.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView_Client_List.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.IP,
            this.Client_Primary_Key});
            this.listView_Client_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_Client_List.Location = new System.Drawing.Point(3, 22);
            this.listView_Client_List.Name = "listView_Client_List";
            this.listView_Client_List.Size = new System.Drawing.Size(302, 280);
            this.listView_Client_List.TabIndex = 11;
            this.listView_Client_List.UseCompatibleStateImageBehavior = false;
            this.listView_Client_List.View = System.Windows.Forms.View.Details;
            // 
            // label_Client_List
            // 
            this.label_Client_List.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Client_List.AutoSize = true;
            this.label_Client_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Client_List.Location = new System.Drawing.Point(0, 0);
            this.label_Client_List.Name = "label_Client_List";
            this.label_Client_List.Size = new System.Drawing.Size(78, 20);
            this.label_Client_List.TabIndex = 10;
            this.label_Client_List.Text = "Client List";
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 80;
            // 
            // IP
            // 
            this.IP.Text = "IP";
            this.IP.Width = 100;
            // 
            // Client_Primary_Key
            // 
            this.Client_Primary_Key.Text = "Client Primary Key";
            this.Client_Primary_Key.Width = 120;
            // 
            // Form_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(697, 439);
            this.Controls.Add(this.panel_Server_Log);
            this.Controls.Add(this.panel_Connect_Log);
            this.Controls.Add(this.panel_Sever_IP);
            this.Name = "Form_Server";
            this.Text = "Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Server_FormClosed);
            this.Load += new System.EventHandler(this.Form_Server_Load);
            this.panel_Sever_IP.ResumeLayout(false);
            this.panel_Sever_IP.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_Server_Log.ResumeLayout(false);
            this.panel_Server_Log.PerformLayout();
            this.panel_Connect_Log.ResumeLayout(false);
            this.panel_Connect_Log.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel panel_Connect_Log;
        private System.Windows.Forms.Label label_Client_List;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_Storage_Path;
        private System.Windows.Forms.TextBox textBox_Storage_Path;
        private System.Windows.Forms.Button button_Find_Path;
        private System.Windows.Forms.FolderBrowserDialog folder_Browser_Dialog;
        private System.Windows.Forms.ListView listView_Client_List;
        private System.Windows.Forms.Label label_Down_UP_Load_Log;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader IP;
        private System.Windows.Forms.ColumnHeader Client_Primary_Key;
    }
}

