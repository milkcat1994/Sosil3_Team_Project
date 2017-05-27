using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Client
{
    public partial class Leave_Project : Form
    {
        public delegate void FormSendDataHandler(string obj, string flag);
        public event FormSendDataHandler FormSendEvent;

        //First Form Load Function
        public Leave_Project()
        {
            InitializeComponent();
            textBox_Project_Name.Text = "ThirdProject";
        }
        
        private void button_Leave_Project_Click(object sender, EventArgs e)
        {
            //if do not typing in the textbox, show MessageBox
            if (textBox_Project_Name.Text == "")
            {
                MessageBox.Show("탈퇴할 Project의 이름을 적어주세요");
                return;
            }
            string tempStr = textBox_Project_Name.Text;
            //send event to Client's Form
            this.FormSendEvent(tempStr, "Leave");
        }

        private void Leave_Project_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}
