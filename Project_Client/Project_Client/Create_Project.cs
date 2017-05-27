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
    public partial class Create_Project : Form
    {
        public delegate void FormSendDataHandler(string obj, string flag);
        public event FormSendDataHandler FormSendEvent;

        //First Form Load Function
        public Create_Project()
        {
            InitializeComponent();
            textBox_Project_Name.Text = "FourthProject";
            textBox_Project_Start_Date.Text = "2017-05-12";
            textBox_Project_End_Date.Text = "2017-06-13";
        }

        private void button_Create_Project_Click(object sender, EventArgs e)
        {
            //if do not typing in the textbox, show MessageBox
            if (textBox_Project_Name.Text == "")
            {
                MessageBox.Show("만들 Project의 이름을 적어주세요");
                return;
            }
            else if (textBox_Project_Start_Date.Text == "")
            {
                MessageBox.Show("만들 Project의 시작 날짜를 적어주세요");
                return;
            }
            else if (textBox_Project_End_Date.Text == "")
            {
                MessageBox.Show("만들 Project의 종료 날짜를 적어주세요");
                return;
            }
            //use split rule : ','
            string tempStr = textBox_Project_Name.Text + ","
                + textBox_Project_Start_Date.Text + ","
                + textBox_Project_End_Date.Text;
            //send event to Client's Form
            this.FormSendEvent(tempStr, "Create");
        }

        private void Create_Project_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}
