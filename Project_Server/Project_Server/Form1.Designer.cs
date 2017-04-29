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
            this.textBox_Down_Up_Load_Log = new System.Windows.Forms.TextBox();
            this.label_Sever_Status1 = new System.Windows.Forms.Label();
            this.label_Server_Status = new System.Windows.Forms.Label();
            this.panel_Connect_Log = new System.Windows.Forms.Panel();
            this.textBox_Connect_Log = new System.Windows.Forms.TextBox();
            this.label_Server_Status2 = new System.Windows.Forms.Label();
            this.panel_Sever_IP.SuspendLayout();
            this.panel_Sever_Port.SuspendLayout();
            this.panel_Server_Log.SuspendLayout();
            this.panel_Connect_Log.SuspendLayout();
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
            this.textBox_IP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_IP.Enabled = false;
            this.textBox_IP.Location = new System.Drawing.Point(24, 0);
            this.textBox_IP.Name = "textBox_IP";
            this.textBox_IP.Size = new System.Drawing.Size(294, 21);
            this.textBox_IP.TabIndex = 1;
            // 
            // label_IP
            // 
            this.label_IP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_IP.AutoSize = true;
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
            this.label_Port.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Port.AutoSize = true;
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
            // 
            // panel_Server_Log
            // 
            this.panel_Server_Log.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Server_Log.Controls.Add(this.textBox_Down_Up_Load_Log);
            this.panel_Server_Log.Location = new System.Drawing.Point(15, 63);
            this.panel_Server_Log.Name = "panel_Server_Log";
            this.panel_Server_Log.Size = new System.Drawing.Size(318, 314);
            this.panel_Server_Log.TabIndex = 5;
            // 
            // textBox_Down_Up_Load_Log
            // 
            this.textBox_Down_Up_Load_Log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Down_Up_Load_Log.Location = new System.Drawing.Point(0, 0);
            this.textBox_Down_Up_Load_Log.Multiline = true;
            this.textBox_Down_Up_Load_Log.Name = "textBox_Down_Up_Load_Log";
            this.textBox_Down_Up_Load_Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Down_Up_Load_Log.Size = new System.Drawing.Size(318, 314);
            this.textBox_Down_Up_Load_Log.TabIndex = 0;
            this.textBox_Down_Up_Load_Log.TabStop = false;
            // 
            // label_Sever_Status1
            // 
            this.label_Sever_Status1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Sever_Status1.AutoSize = true;
            this.label_Sever_Status1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_Sever_Status1.Location = new System.Drawing.Point(13, 48);
            this.label_Sever_Status1.Name = "label_Sever_Status1";
            this.label_Sever_Status1.Size = new System.Drawing.Size(131, 12);
            this.label_Sever_Status1.TabIndex = 7;
            this.label_Sever_Status1.Text = "Down-Up Load Log";
            // 
            // label_Server_Status
            // 
            this.label_Server_Status.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Server_Status.AutoSize = true;
            this.label_Server_Status.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_Server_Status.ForeColor = System.Drawing.Color.Red;
            this.label_Server_Status.Location = new System.Drawing.Point(566, 48);
            this.label_Server_Status.Name = "label_Server_Status";
            this.label_Server_Status.Size = new System.Drawing.Size(85, 12);
            this.label_Server_Status.TabIndex = 8;
            this.label_Server_Status.Text = "Not Running";
            // 
            // panel_Connect_Log
            // 
            this.panel_Connect_Log.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Connect_Log.Controls.Add(this.textBox_Connect_Log);
            this.panel_Connect_Log.Location = new System.Drawing.Point(339, 63);
            this.panel_Connect_Log.Name = "panel_Connect_Log";
            this.panel_Connect_Log.Size = new System.Drawing.Size(332, 314);
            this.panel_Connect_Log.TabIndex = 9;
            // 
            // textBox_Connect_Log
            // 
            this.textBox_Connect_Log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Connect_Log.Location = new System.Drawing.Point(0, 0);
            this.textBox_Connect_Log.Multiline = true;
            this.textBox_Connect_Log.Name = "textBox_Connect_Log";
            this.textBox_Connect_Log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_Connect_Log.Size = new System.Drawing.Size(332, 314);
            this.textBox_Connect_Log.TabIndex = 0;
            // 
            // label_Server_Status2
            // 
            this.label_Server_Status2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Server_Status2.AutoSize = true;
            this.label_Server_Status2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_Server_Status2.Location = new System.Drawing.Point(337, 48);
            this.label_Server_Status2.Name = "label_Server_Status2";
            this.label_Server_Status2.Size = new System.Drawing.Size(108, 12);
            this.label_Server_Status2.TabIndex = 10;
            this.label_Server_Status2.Text = "Connection Log";
            // 
            // Form_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 394);
            this.Controls.Add(this.label_Server_Status2);
            this.Controls.Add(this.panel_Connect_Log);
            this.Controls.Add(this.label_Server_Status);
            this.Controls.Add(this.label_Sever_Status1);
            this.Controls.Add(this.panel_Server_Log);
            this.Controls.Add(this.button_Server_Start);
            this.Controls.Add(this.panel_Sever_Port);
            this.Controls.Add(this.panel_Sever_IP);
            this.Name = "Form_Server";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Form_Server_Load);
            this.panel_Sever_IP.ResumeLayout(false);
            this.panel_Sever_IP.PerformLayout();
            this.panel_Sever_Port.ResumeLayout(false);
            this.panel_Sever_Port.PerformLayout();
            this.panel_Server_Log.ResumeLayout(false);
            this.panel_Server_Log.PerformLayout();
            this.panel_Connect_Log.ResumeLayout(false);
            this.panel_Connect_Log.PerformLayout();
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
        private System.Windows.Forms.Label label_Sever_Status1;
        private System.Windows.Forms.Label label_Server_Status;
        private System.Windows.Forms.Panel panel_Connect_Log;
        private System.Windows.Forms.TextBox textBox_Connect_Log;
        private System.Windows.Forms.Label label_Server_Status2;
    }
}

