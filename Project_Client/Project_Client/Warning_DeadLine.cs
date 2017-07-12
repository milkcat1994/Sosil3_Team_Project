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
    public partial class Warning_DeadLine : Form
    {
        int Location_Width, Location_Height;
        public Warning_DeadLine(string Current_DeadLine_Alert_Str)
        {
            InitializeComponent();
            Location_Width = Screen.PrimaryScreen.Bounds.Width;
            Location_Height = Screen.PrimaryScreen.Bounds.Height;

            //Manual 지정
            this.StartPosition = FormStartPosition.Manual;

            //위치 지정
            this.Location = new Point(Location_Width-this.Width, Location_Height-this.Height*2);
            //this.Show();
            label_Warning_Text.Text = Current_DeadLine_Alert_Str;
        }

        private void Warning_DeadLine_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}