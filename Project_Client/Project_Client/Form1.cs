using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project_Client
{
    public partial class Form_Client : Form
    {
        public Form_Client()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\school\3\Linux\Project\Project_Server\Project_Server\Server_DB.mdf; Integrated Security = True; Connect Timeout = 30");
            string query = "select * from Login where Id ='" + textBox_ID.Text.Trim() + "'and password = '" + textBox_PW.Text.Trim() + "'";
            SqlDataAdapter sqla = new SqlDataAdapter(query, sqlCon);
            DataTable dt = new DataTable();
            sqla.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                panel_First.Visible = false;
                Form_Client.ActiveForm.Width = 200;
                Form_Client.ActiveForm.Height = 200;
            }
            else
            {
                MessageBox.Show("re write!! pw");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Client.ActiveForm.Width = 600;
            Form_Client.ActiveForm.Height = 600;
            panel_First.Visible = true;
        }
    }
}
