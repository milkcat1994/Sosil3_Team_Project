namespace Project_Client
{
    partial class Join_Project
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
            this.panel_Project_Name = new System.Windows.Forms.Panel();
            this.label_Project_name = new System.Windows.Forms.Label();
            this.textBox_Project_Name = new System.Windows.Forms.TextBox();
            this.button_Join_Project = new System.Windows.Forms.Button();
            this.panel_Project_Name.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Project_Name
            // 
            this.panel_Project_Name.Controls.Add(this.label_Project_name);
            this.panel_Project_Name.Controls.Add(this.textBox_Project_Name);
            this.panel_Project_Name.Location = new System.Drawing.Point(12, 12);
            this.panel_Project_Name.Name = "panel_Project_Name";
            this.panel_Project_Name.Size = new System.Drawing.Size(239, 25);
            this.panel_Project_Name.TabIndex = 0;
            // 
            // label_Project_name
            // 
            this.label_Project_name.AutoSize = true;
            this.label_Project_name.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_Project_name.Location = new System.Drawing.Point(0, 0);
            this.label_Project_name.Name = "label_Project_name";
            this.label_Project_name.Size = new System.Drawing.Size(88, 12);
            this.label_Project_name.TabIndex = 1;
            this.label_Project_name.Text = "Project_Name:";
            // 
            // textBox_Project_Name
            // 
            this.textBox_Project_Name.Location = new System.Drawing.Point(94, 0);
            this.textBox_Project_Name.Name = "textBox_Project_Name";
            this.textBox_Project_Name.Size = new System.Drawing.Size(145, 21);
            this.textBox_Project_Name.TabIndex = 0;
            // 
            // button_Join_Project
            // 
            this.button_Join_Project.Location = new System.Drawing.Point(271, 14);
            this.button_Join_Project.Name = "button_Join_Project";
            this.button_Join_Project.Size = new System.Drawing.Size(91, 23);
            this.button_Join_Project.TabIndex = 1;
            this.button_Join_Project.Text = "Join_Project";
            this.button_Join_Project.UseVisualStyleBackColor = true;
            this.button_Join_Project.Click += new System.EventHandler(this.button_Join_Project_Click);
            // 
            // Join_Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 57);
            this.Controls.Add(this.button_Join_Project);
            this.Controls.Add(this.panel_Project_Name);
            this.Name = "Join_Project";
            this.Text = "Join_Project";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Join_Project_FormClosed);
            this.panel_Project_Name.ResumeLayout(false);
            this.panel_Project_Name.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Project_Name;
        private System.Windows.Forms.Label label_Project_name;
        private System.Windows.Forms.TextBox textBox_Project_Name;
        private System.Windows.Forms.Button button_Join_Project;
    }
}