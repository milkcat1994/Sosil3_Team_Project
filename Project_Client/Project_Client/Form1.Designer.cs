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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel_First = new System.Windows.Forms.Panel();
            this.panel_ID.SuspendLayout();
            this.panel_PW.SuspendLayout();
            this.panel_IP.SuspendLayout();
            this.panel_Port.SuspendLayout();
            this.panel_First.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_ID
            // 
            this.panel_ID.Controls.Add(this.textBox_ID);
            this.panel_ID.Controls.Add(this.label_ID);
            this.panel_ID.Location = new System.Drawing.Point(34, 83);
            this.panel_ID.Name = "panel_ID";
            this.panel_ID.Size = new System.Drawing.Size(171, 25);
            this.panel_ID.TabIndex = 0;
            // 
            // textBox_ID
            // 
            this.textBox_ID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_ID.Location = new System.Drawing.Point(24, 0);
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
            this.panel_PW.Location = new System.Drawing.Point(56, 144);
            this.panel_PW.Name = "panel_PW";
            this.panel_PW.Size = new System.Drawing.Size(181, 25);
            this.panel_PW.TabIndex = 1;
            // 
            // textBox_PW
            // 
            this.textBox_PW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_PW.Location = new System.Drawing.Point(31, 0);
            this.textBox_PW.Name = "textBox_PW";
            this.textBox_PW.Size = new System.Drawing.Size(150, 21);
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
            this.panel_Port.Location = new System.Drawing.Point(224, 70);
            this.panel_Port.Name = "panel_Port";
            this.panel_Port.Size = new System.Drawing.Size(171, 25);
            this.panel_Port.TabIndex = 2;
            // 
            // textBox_Port
            // 
            this.textBox_Port.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Port.Location = new System.Drawing.Point(35, 0);
            this.textBox_Port.Name = "textBox_Port";
            this.textBox_Port.Size = new System.Drawing.Size(136, 21);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(110, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel_First
            // 
            this.panel_First.Controls.Add(this.panel_IP);
            this.panel_First.Controls.Add(this.panel_Port);
            this.panel_First.Controls.Add(this.panel_ID);
            this.panel_First.Controls.Add(this.panel_PW);
            this.panel_First.Location = new System.Drawing.Point(12, 31);
            this.panel_First.Name = "panel_First";
            this.panel_First.Size = new System.Drawing.Size(404, 367);
            this.panel_First.TabIndex = 2;
            // 
            // Form_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 407);
            this.Controls.Add(this.panel_First);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form_Client";
            this.Text = "Client";
            this.panel_ID.ResumeLayout(false);
            this.panel_ID.PerformLayout();
            this.panel_PW.ResumeLayout(false);
            this.panel_PW.PerformLayout();
            this.panel_IP.ResumeLayout(false);
            this.panel_IP.PerformLayout();
            this.panel_Port.ResumeLayout(false);
            this.panel_Port.PerformLayout();
            this.panel_First.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel_First;
    }
}

