namespace Project_Client
{
    partial class Warning_DeadLine
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
            this.label_Warning_Text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Warning_Text
            // 
            this.label_Warning_Text.AutoSize = true;
            this.label_Warning_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Warning_Text.Location = new System.Drawing.Point(12, 19);
            this.label_Warning_Text.Name = "label_Warning_Text";
            this.label_Warning_Text.Size = new System.Drawing.Size(154, 18);
            this.label_Warning_Text.TabIndex = 0;
            this.label_Warning_Text.Text = "Project_Warning_Text";
            // 
            // Warning_DeadLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(353, 56);
            this.Controls.Add(this.label_Warning_Text);
            this.Name = "Warning_DeadLine";
            this.Text = "DeadLine Warning";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Warning_DeadLine_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label_Warning_Text;
    }
}