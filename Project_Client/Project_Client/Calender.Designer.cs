namespace Project_Client
{
    partial class Calender
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label_Month = new System.Windows.Forms.Label();
            this.button_Previous = new System.Windows.Forms.Button();
            this.button_Next = new System.Windows.Forms.Button();
            this.dataGridView_Project_List = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.f35 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_Calender = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.f34 = new System.Windows.Forms.FlowLayoutPanel();
            this.f28 = new System.Windows.Forms.FlowLayoutPanel();
            this.f21 = new System.Windows.Forms.FlowLayoutPanel();
            this.f14 = new System.Windows.Forms.FlowLayoutPanel();
            this.f7 = new System.Windows.Forms.FlowLayoutPanel();
            this.f27 = new System.Windows.Forms.FlowLayoutPanel();
            this.f20 = new System.Windows.Forms.FlowLayoutPanel();
            this.f13 = new System.Windows.Forms.FlowLayoutPanel();
            this.f6 = new System.Windows.Forms.FlowLayoutPanel();
            this.f33 = new System.Windows.Forms.FlowLayoutPanel();
            this.f32 = new System.Windows.Forms.FlowLayoutPanel();
            this.f31 = new System.Windows.Forms.FlowLayoutPanel();
            this.f30 = new System.Windows.Forms.FlowLayoutPanel();
            this.f29 = new System.Windows.Forms.FlowLayoutPanel();
            this.f26 = new System.Windows.Forms.FlowLayoutPanel();
            this.f25 = new System.Windows.Forms.FlowLayoutPanel();
            this.f24 = new System.Windows.Forms.FlowLayoutPanel();
            this.f23 = new System.Windows.Forms.FlowLayoutPanel();
            this.f22 = new System.Windows.Forms.FlowLayoutPanel();
            this.f19 = new System.Windows.Forms.FlowLayoutPanel();
            this.f18 = new System.Windows.Forms.FlowLayoutPanel();
            this.f17 = new System.Windows.Forms.FlowLayoutPanel();
            this.f16 = new System.Windows.Forms.FlowLayoutPanel();
            this.f15 = new System.Windows.Forms.FlowLayoutPanel();
            this.f12 = new System.Windows.Forms.FlowLayoutPanel();
            this.f11 = new System.Windows.Forms.FlowLayoutPanel();
            this.f10 = new System.Windows.Forms.FlowLayoutPanel();
            this.f9 = new System.Windows.Forms.FlowLayoutPanel();
            this.f8 = new System.Windows.Forms.FlowLayoutPanel();
            this.f5 = new System.Windows.Forms.FlowLayoutPanel();
            this.f4 = new System.Windows.Forms.FlowLayoutPanel();
            this.f3 = new System.Windows.Forms.FlowLayoutPanel();
            this.f2 = new System.Windows.Forms.FlowLayoutPanel();
            this.f1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Project_List)).BeginInit();
            this.panel_Calender.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Month
            // 
            this.label_Month.AutoSize = true;
            this.label_Month.Font = new System.Drawing.Font("휴먼옛체", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_Month.Location = new System.Drawing.Point(725, 83);
            this.label_Month.Name = "label_Month";
            this.label_Month.Size = new System.Drawing.Size(17, 16);
            this.label_Month.TabIndex = 2;
            this.label_Month.Text = "6";
            // 
            // button_Previous
            // 
            this.button_Previous.Font = new System.Drawing.Font("휴먼옛체", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_Previous.Location = new System.Drawing.Point(493, 83);
            this.button_Previous.Name = "button_Previous";
            this.button_Previous.Size = new System.Drawing.Size(89, 23);
            this.button_Previous.TabIndex = 6;
            this.button_Previous.Text = "Previous";
            this.button_Previous.UseVisualStyleBackColor = true;
            this.button_Previous.Click += new System.EventHandler(this.button_Previous_Click);
            // 
            // button_Next
            // 
            this.button_Next.Font = new System.Drawing.Font("휴먼옛체", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_Next.Location = new System.Drawing.Point(893, 83);
            this.button_Next.Name = "button_Next";
            this.button_Next.Size = new System.Drawing.Size(87, 23);
            this.button_Next.TabIndex = 7;
            this.button_Next.Text = "Next";
            this.button_Next.UseVisualStyleBackColor = true;
            this.button_Next.Click += new System.EventHandler(this.button_Next_Click);
            // 
            // dataGridView_Project_List
            // 
            this.dataGridView_Project_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Project_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView_Project_List.Location = new System.Drawing.Point(4, 180);
            this.dataGridView_Project_List.Name = "dataGridView_Project_List";
            this.dataGridView_Project_List.RowTemplate.Height = 23;
            this.dataGridView_Project_List.Size = new System.Drawing.Size(367, 413);
            this.dataGridView_Project_List.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "NO.";
            this.Column1.Name = "Column1";
            this.Column1.Width = 25;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Start Date";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "End Date";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "D-day";
            this.Column4.Name = "Column4";
            this.Column4.Width = 50;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Color";
            this.Column5.Name = "Column5";
            // 
            // f35
            // 
            this.f35.BackColor = System.Drawing.SystemColors.Window;
            this.f35.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.f35.Location = new System.Drawing.Point(663, 452);
            this.f35.Name = "f35";
            this.f35.Size = new System.Drawing.Size(105, 60);
            this.f35.TabIndex = 61;
            // 
            // panel_Calender
            // 
            this.panel_Calender.BackgroundImage = global::Project_Client.Properties.Resources.june;
            this.panel_Calender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Calender.Controls.Add(this.f1);
            this.panel_Calender.Controls.Add(this.f2);
            this.panel_Calender.Controls.Add(this.f3);
            this.panel_Calender.Controls.Add(this.f4);
            this.panel_Calender.Controls.Add(this.f5);
            this.panel_Calender.Controls.Add(this.f8);
            this.panel_Calender.Controls.Add(this.f9);
            this.panel_Calender.Controls.Add(this.f10);
            this.panel_Calender.Controls.Add(this.f11);
            this.panel_Calender.Controls.Add(this.f12);
            this.panel_Calender.Controls.Add(this.f15);
            this.panel_Calender.Controls.Add(this.f16);
            this.panel_Calender.Controls.Add(this.f17);
            this.panel_Calender.Controls.Add(this.f18);
            this.panel_Calender.Controls.Add(this.f19);
            this.panel_Calender.Controls.Add(this.f22);
            this.panel_Calender.Controls.Add(this.f23);
            this.panel_Calender.Controls.Add(this.f24);
            this.panel_Calender.Controls.Add(this.f25);
            this.panel_Calender.Controls.Add(this.f26);
            this.panel_Calender.Controls.Add(this.f29);
            this.panel_Calender.Controls.Add(this.f30);
            this.panel_Calender.Controls.Add(this.f31);
            this.panel_Calender.Controls.Add(this.f32);
            this.panel_Calender.Controls.Add(this.f33);
            this.panel_Calender.Controls.Add(this.f6);
            this.panel_Calender.Controls.Add(this.f13);
            this.panel_Calender.Controls.Add(this.f20);
            this.panel_Calender.Controls.Add(this.f27);
            this.panel_Calender.Controls.Add(this.f7);
            this.panel_Calender.Controls.Add(this.f14);
            this.panel_Calender.Controls.Add(this.f21);
            this.panel_Calender.Controls.Add(this.f28);
            this.panel_Calender.Controls.Add(this.f34);
            this.panel_Calender.Controls.Add(this.f35);
            this.panel_Calender.Location = new System.Drawing.Point(388, 121);
            this.panel_Calender.Name = "panel_Calender";
            this.panel_Calender.Size = new System.Drawing.Size(770, 515);
            this.panel_Calender.TabIndex = 11;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // f34
            // 
            this.f34.BackColor = System.Drawing.SystemColors.Window;
            this.f34.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.f34.Location = new System.Drawing.Point(553, 452);
            this.f34.Name = "f34";
            this.f34.Size = new System.Drawing.Size(115, 60);
            this.f34.TabIndex = 62;
            // 
            // f28
            // 
            this.f28.BackColor = System.Drawing.SystemColors.Window;
            this.f28.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.f28.Location = new System.Drawing.Point(663, 373);
            this.f28.Name = "f28";
            this.f28.Size = new System.Drawing.Size(105, 60);
            this.f28.TabIndex = 62;
            // 
            // f21
            // 
            this.f21.BackColor = System.Drawing.SystemColors.Window;
            this.f21.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.f21.Location = new System.Drawing.Point(663, 292);
            this.f21.Name = "f21";
            this.f21.Size = new System.Drawing.Size(105, 60);
            this.f21.TabIndex = 63;
            // 
            // f14
            // 
            this.f14.BackColor = System.Drawing.SystemColors.Window;
            this.f14.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.f14.Location = new System.Drawing.Point(663, 211);
            this.f14.Name = "f14";
            this.f14.Size = new System.Drawing.Size(105, 60);
            this.f14.TabIndex = 64;
            // 
            // f7
            // 
            this.f7.BackColor = System.Drawing.SystemColors.Window;
            this.f7.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.f7.Location = new System.Drawing.Point(663, 131);
            this.f7.Name = "f7";
            this.f7.Size = new System.Drawing.Size(105, 60);
            this.f7.TabIndex = 65;
            // 
            // f27
            // 
            this.f27.BackColor = System.Drawing.SystemColors.Window;
            this.f27.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.f27.Location = new System.Drawing.Point(553, 373);
            this.f27.Name = "f27";
            this.f27.Size = new System.Drawing.Size(115, 60);
            this.f27.TabIndex = 63;
            // 
            // f20
            // 
            this.f20.BackColor = System.Drawing.SystemColors.Window;
            this.f20.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.f20.Location = new System.Drawing.Point(553, 292);
            this.f20.Name = "f20";
            this.f20.Size = new System.Drawing.Size(115, 60);
            this.f20.TabIndex = 64;
            // 
            // f13
            // 
            this.f13.BackColor = System.Drawing.SystemColors.Window;
            this.f13.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.f13.Location = new System.Drawing.Point(553, 211);
            this.f13.Name = "f13";
            this.f13.Size = new System.Drawing.Size(115, 60);
            this.f13.TabIndex = 64;
            // 
            // f6
            // 
            this.f6.BackColor = System.Drawing.SystemColors.Window;
            this.f6.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.f6.Location = new System.Drawing.Point(553, 131);
            this.f6.Name = "f6";
            this.f6.Size = new System.Drawing.Size(115, 60);
            this.f6.TabIndex = 64;
            // 
            // f33
            // 
            this.f33.BackColor = System.Drawing.SystemColors.Window;
            this.f33.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.f33.Location = new System.Drawing.Point(443, 452);
            this.f33.Name = "f33";
            this.f33.Size = new System.Drawing.Size(115, 60);
            this.f33.TabIndex = 63;
            // 
            // f32
            // 
            this.f32.BackColor = System.Drawing.SystemColors.Window;
            this.f32.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.f32.Location = new System.Drawing.Point(333, 452);
            this.f32.Name = "f32";
            this.f32.Size = new System.Drawing.Size(115, 60);
            this.f32.TabIndex = 64;
            // 
            // f31
            // 
            this.f31.BackColor = System.Drawing.SystemColors.Window;
            this.f31.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.f31.Location = new System.Drawing.Point(223, 452);
            this.f31.Name = "f31";
            this.f31.Size = new System.Drawing.Size(115, 60);
            this.f31.TabIndex = 65;
            // 
            // f30
            // 
            this.f30.BackColor = System.Drawing.SystemColors.Window;
            this.f30.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.f30.Location = new System.Drawing.Point(113, 452);
            this.f30.Name = "f30";
            this.f30.Size = new System.Drawing.Size(115, 60);
            this.f30.TabIndex = 66;
            // 
            // f29
            // 
            this.f29.BackColor = System.Drawing.SystemColors.Window;
            this.f29.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.f29.Location = new System.Drawing.Point(3, 452);
            this.f29.Name = "f29";
            this.f29.Size = new System.Drawing.Size(115, 60);
            this.f29.TabIndex = 67;
            // 
            // f26
            // 
            this.f26.BackColor = System.Drawing.SystemColors.Window;
            this.f26.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.f26.Location = new System.Drawing.Point(443, 373);
            this.f26.Name = "f26";
            this.f26.Size = new System.Drawing.Size(115, 60);
            this.f26.TabIndex = 68;
            // 
            // f25
            // 
            this.f25.BackColor = System.Drawing.SystemColors.Window;
            this.f25.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.f25.Location = new System.Drawing.Point(333, 373);
            this.f25.Name = "f25";
            this.f25.Size = new System.Drawing.Size(115, 60);
            this.f25.TabIndex = 68;
            // 
            // f24
            // 
            this.f24.BackColor = System.Drawing.SystemColors.Window;
            this.f24.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.f24.Location = new System.Drawing.Point(223, 373);
            this.f24.Name = "f24";
            this.f24.Size = new System.Drawing.Size(115, 60);
            this.f24.TabIndex = 68;
            // 
            // f23
            // 
            this.f23.BackColor = System.Drawing.SystemColors.Window;
            this.f23.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.f23.Location = new System.Drawing.Point(113, 373);
            this.f23.Name = "f23";
            this.f23.Size = new System.Drawing.Size(115, 60);
            this.f23.TabIndex = 68;
            // 
            // f22
            // 
            this.f22.BackColor = System.Drawing.SystemColors.Window;
            this.f22.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.f22.Location = new System.Drawing.Point(3, 373);
            this.f22.Name = "f22";
            this.f22.Size = new System.Drawing.Size(115, 60);
            this.f22.TabIndex = 68;
            // 
            // f19
            // 
            this.f19.BackColor = System.Drawing.SystemColors.Window;
            this.f19.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.f19.Location = new System.Drawing.Point(443, 292);
            this.f19.Name = "f19";
            this.f19.Size = new System.Drawing.Size(115, 60);
            this.f19.TabIndex = 68;
            // 
            // f18
            // 
            this.f18.BackColor = System.Drawing.SystemColors.Window;
            this.f18.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.f18.Location = new System.Drawing.Point(333, 292);
            this.f18.Name = "f18";
            this.f18.Size = new System.Drawing.Size(115, 60);
            this.f18.TabIndex = 68;
            // 
            // f17
            // 
            this.f17.BackColor = System.Drawing.SystemColors.Window;
            this.f17.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.f17.Location = new System.Drawing.Point(223, 292);
            this.f17.Name = "f17";
            this.f17.Size = new System.Drawing.Size(115, 60);
            this.f17.TabIndex = 68;
            // 
            // f16
            // 
            this.f16.BackColor = System.Drawing.SystemColors.Window;
            this.f16.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.f16.Location = new System.Drawing.Point(113, 292);
            this.f16.Name = "f16";
            this.f16.Size = new System.Drawing.Size(115, 60);
            this.f16.TabIndex = 68;
            // 
            // f15
            // 
            this.f15.BackColor = System.Drawing.SystemColors.Window;
            this.f15.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.f15.Location = new System.Drawing.Point(3, 292);
            this.f15.Name = "f15";
            this.f15.Size = new System.Drawing.Size(115, 60);
            this.f15.TabIndex = 68;
            // 
            // f12
            // 
            this.f12.BackColor = System.Drawing.SystemColors.Window;
            this.f12.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.f12.Location = new System.Drawing.Point(443, 211);
            this.f12.Name = "f12";
            this.f12.Size = new System.Drawing.Size(115, 60);
            this.f12.TabIndex = 68;
            // 
            // f11
            // 
            this.f11.BackColor = System.Drawing.SystemColors.Window;
            this.f11.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.f11.Location = new System.Drawing.Point(333, 211);
            this.f11.Name = "f11";
            this.f11.Size = new System.Drawing.Size(115, 60);
            this.f11.TabIndex = 68;
            // 
            // f10
            // 
            this.f10.BackColor = System.Drawing.SystemColors.Window;
            this.f10.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.f10.Location = new System.Drawing.Point(223, 211);
            this.f10.Name = "f10";
            this.f10.Size = new System.Drawing.Size(115, 60);
            this.f10.TabIndex = 68;
            // 
            // f9
            // 
            this.f9.BackColor = System.Drawing.SystemColors.Window;
            this.f9.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.f9.Location = new System.Drawing.Point(113, 211);
            this.f9.Name = "f9";
            this.f9.Size = new System.Drawing.Size(115, 60);
            this.f9.TabIndex = 68;
            // 
            // f8
            // 
            this.f8.BackColor = System.Drawing.SystemColors.Window;
            this.f8.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.f8.Location = new System.Drawing.Point(3, 211);
            this.f8.Name = "f8";
            this.f8.Size = new System.Drawing.Size(115, 60);
            this.f8.TabIndex = 68;
            // 
            // f5
            // 
            this.f5.BackColor = System.Drawing.SystemColors.Window;
            this.f5.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.f5.Location = new System.Drawing.Point(443, 131);
            this.f5.Name = "f5";
            this.f5.Size = new System.Drawing.Size(115, 60);
            this.f5.TabIndex = 68;
            // 
            // f4
            // 
            this.f4.BackColor = System.Drawing.SystemColors.Window;
            this.f4.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.f4.Location = new System.Drawing.Point(333, 131);
            this.f4.Name = "f4";
            this.f4.Size = new System.Drawing.Size(115, 60);
            this.f4.TabIndex = 68;
            // 
            // f3
            // 
            this.f3.BackColor = System.Drawing.SystemColors.Window;
            this.f3.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.f3.Location = new System.Drawing.Point(223, 131);
            this.f3.Name = "f3";
            this.f3.Size = new System.Drawing.Size(115, 60);
            this.f3.TabIndex = 68;
            // 
            // f2
            // 
            this.f2.BackColor = System.Drawing.SystemColors.Window;
            this.f2.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.f2.Location = new System.Drawing.Point(113, 131);
            this.f2.Name = "f2";
            this.f2.Size = new System.Drawing.Size(115, 60);
            this.f2.TabIndex = 68;
            // 
            // f1
            // 
            this.f1.BackColor = System.Drawing.SystemColors.Window;
            this.f1.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.f1.Location = new System.Drawing.Point(3, 131);
            this.f1.Name = "f1";
            this.f1.Size = new System.Drawing.Size(115, 60);
            this.f1.TabIndex = 68;
            // 
            // Calender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 676);
            this.Controls.Add(this.panel_Calender);
            this.Controls.Add(this.dataGridView_Project_List);
            this.Controls.Add(this.button_Next);
            this.Controls.Add(this.button_Previous);
            this.Controls.Add(this.label_Month);
            this.Name = "Calender";
            this.Text = "Calender";
            this.Load += new System.EventHandler(this.Calender_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Project_List)).EndInit();
            this.panel_Calender.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_Month;
        private System.Windows.Forms.Button button_Previous;
        private System.Windows.Forms.Button button_Next;
        private System.Windows.Forms.DataGridView dataGridView_Project_List;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.FlowLayoutPanel f35;
        private System.Windows.Forms.Panel panel_Calender;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FlowLayoutPanel f34;
        private System.Windows.Forms.FlowLayoutPanel f28;
        private System.Windows.Forms.FlowLayoutPanel f1;
        private System.Windows.Forms.FlowLayoutPanel f2;
        private System.Windows.Forms.FlowLayoutPanel f3;
        private System.Windows.Forms.FlowLayoutPanel f4;
        private System.Windows.Forms.FlowLayoutPanel f5;
        private System.Windows.Forms.FlowLayoutPanel f8;
        private System.Windows.Forms.FlowLayoutPanel f9;
        private System.Windows.Forms.FlowLayoutPanel f10;
        private System.Windows.Forms.FlowLayoutPanel f11;
        private System.Windows.Forms.FlowLayoutPanel f12;
        private System.Windows.Forms.FlowLayoutPanel f15;
        private System.Windows.Forms.FlowLayoutPanel f16;
        private System.Windows.Forms.FlowLayoutPanel f17;
        private System.Windows.Forms.FlowLayoutPanel f18;
        private System.Windows.Forms.FlowLayoutPanel f19;
        private System.Windows.Forms.FlowLayoutPanel f22;
        private System.Windows.Forms.FlowLayoutPanel f23;
        private System.Windows.Forms.FlowLayoutPanel f24;
        private System.Windows.Forms.FlowLayoutPanel f25;
        private System.Windows.Forms.FlowLayoutPanel f26;
        private System.Windows.Forms.FlowLayoutPanel f29;
        private System.Windows.Forms.FlowLayoutPanel f30;
        private System.Windows.Forms.FlowLayoutPanel f31;
        private System.Windows.Forms.FlowLayoutPanel f32;
        private System.Windows.Forms.FlowLayoutPanel f33;
        private System.Windows.Forms.FlowLayoutPanel f6;
        private System.Windows.Forms.FlowLayoutPanel f13;
        private System.Windows.Forms.FlowLayoutPanel f20;
        private System.Windows.Forms.FlowLayoutPanel f27;
        private System.Windows.Forms.FlowLayoutPanel f7;
        private System.Windows.Forms.FlowLayoutPanel f14;
        private System.Windows.Forms.FlowLayoutPanel f21;
    }
}

