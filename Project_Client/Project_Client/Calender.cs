using System;
using System.Drawing;
using System.Windows.Forms;


namespace Project_Client
{
    public partial class Calender : Form
    {
        //for send year and month  to server
        public delegate void FormSendDataHandler(int year, int month);
        public event FormSendDataHandler FormSendEvent;

        Form_Client parent_Form;
        
        private int currentYear = 2017;
        private int currentDay;
        public string[] start_Date;
        public string[] end_Date;
        public bool flag;
        int month = 6;
        
        int[] k = new int[35];
        
        FlowLayoutPanel[] f_list = new FlowLayoutPanel[35];

        Label[] label_list1 = new Label[35];
        Label[] label_list2 = new Label[35];
        Label[] label_list3 = new Label[35];
        Label[] label_list4 = new Label[35];

        int[] day_In_Month = new int[] { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        //start, end Day Point at Month
        int lastYear;

        System.Windows.Forms.Label label;
        public Calender()
        {
            
            InitializeComponent();
            //setting parent Form
            parent_Form = (Form_Client)this.Owner;
            //start_Date = new string[30];
            //end_Date = new string[30];
            flag = false;
            currentDay = 0;
            label_Month.Text = "June";
            f_list[0] = f1;          // flow_list
            f_list[1] = f2;
            f_list[2] = f3;
            f_list[3] = f4;
            f_list[4] = f5;
            f_list[5] = f6;
            f_list[6] = f7;
            f_list[7] = f8;
            f_list[8] = f9;
            f_list[9] = f10;
            f_list[10] = f11;
            f_list[11] = f12;
            f_list[12] = f13;
            f_list[13] = f14;
            f_list[14] = f15;
            f_list[15] = f16;
            f_list[16] = f17;
            f_list[17] = f18;
            f_list[18] = f19;
            f_list[19] = f20;
            f_list[20] = f21;
            f_list[21] = f22;
            f_list[22] = f23;
            f_list[23] = f24;
            f_list[24] = f25;
            f_list[25] = f26;
            f_list[26] = f27;
            f_list[27] = f28;
            f_list[28] = f29;
            f_list[29] = f30;
            f_list[30] = f31;
            f_list[31] = f32;
            f_list[32] = f33;
            f_list[33] = f34;
            f_list[34] = f35;
            
        }
       
        private bool leapyear(int year)
        {
            return (year % 4 == 0) && ((year % 100 != 0) || (year%400 == 0));
        }
        

        private void button_Previous_Click(object sender, EventArgs e)
        {
            Init_label();
            month--;

            if (month == 3)
            {
                label_Month.Text = "March";
                panel_Calender.BackgroundImage = Project_Client.Properties.Resources.march;
            }
            else if (month == 4)
            {
                label_Month.Text = "April";
                panel_Calender.BackgroundImage = Project_Client.Properties.Resources.april;
            }
            else if (month == 5)
            {
                label_Month.Text = "May";
                panel_Calender.BackgroundImage = Project_Client.Properties.Resources.may;
            }
            else if (month < 3)
                month = 3;

            //send currentYear, month Data to Server
            this.FormSendEvent(currentYear, month);
            invalidate_panel(k);
        }

        private void button_Next_Click(object sender, EventArgs e)
        {
            Init_label();
            month++;

            if (month == 6)
            {
                label_Month.Text = "June";
                panel_Calender.BackgroundImage = Project_Client.Properties.Resources.june;
                month = 6;
            }
            else if (month == 4)
            {
                label_Month.Text = "April";
                panel_Calender.BackgroundImage = Project_Client.Properties.Resources.april;

            }
            else if (month == 5)
            {
                label_Month.Text = "May";
                panel_Calender.BackgroundImage = Project_Client.Properties.Resources.may;
            }
            else if (month > 6)
                month = 6;

            //send currentYear, month Data to Server
            this.FormSendEvent(currentYear, month);
            invalidate_panel(k);
        }
        
        public void Init_label() // 라벨 초기화 함수
        {
            for (int m = 0; m < 35; m++)
            {
                foreach (Control item in f_list[m].Controls)
                {
                    if (item is Label)
                    {
                        f_list[m].Controls.Clear();
                    }
                }
            }
            for (int i = 0; i < 35; i++)
            {

                label_list1[i] = new System.Windows.Forms.Label();
                label_list1[i].Size = new System.Drawing.Size(112, 10);

            }
            for (int i = 0; i < 35; i++)
            {
                label_list2[i] = new System.Windows.Forms.Label();
                label_list2[i].Size = new System.Drawing.Size(112, 10);

            }
            for (int i = 0; i < 35; i++)
            {

                label_list3[i] = new System.Windows.Forms.Label();

                label_list3[i].Size = new System.Drawing.Size(112, 10);

            }
            for (int i = 0; i < 35; i++)
            {
                label_list4[i] = new System.Windows.Forms.Label();
                label_list4[i].Size = new System.Drawing.Size(112, 10);

            }

            Refresh();    
        }
        
        //윤년계산
        public void calculate_Day()
        {
            currentDay = 0;
            //윤년일 경우 설정
            if (month == 2 && leapyear(currentYear))
                day_In_Month[2] = 29;

            //작년 말까지 진행된 요일 계산 위한 선언
            lastYear = currentYear - 1;

            currentDay = ((lastYear + (lastYear / 4) - (lastYear / 100) + (lastYear / 400) + 1) % 7);

            for (int i = 0; i < month; i++)
                currentDay += day_In_Month[i];
            //0은 일요일 로써 계산됨
            currentDay %= 7;
            currentDay -= 1;
        }
        public void invalidate_panel(int[] k)  // 해당 달에 스케줄 그려주는 함수
        {
            int col_count = 0;
            int start_Day, finish_Day;
            int start_Month, finish_Month;

            DateTime temp_date, temp_date2;

            Init_label();

            for (int j = 0; j < dataGridView_Project_List.RowCount - 1; j++)
            {
                temp_date = DateTime.Parse(dataGridView_Project_List.Rows[j].Cells[1].Value.ToString());
                temp_date2 = DateTime.Parse(dataGridView_Project_List.Rows[j].Cells[2].Value.ToString());

                start_Day = temp_date.Day;
                finish_Day = temp_date2.Day;
                start_Month = temp_date.Month;
                finish_Month = temp_date2.Month;

                //각 월 마다 시작, 끝 위치
                int start_Point = 0, end_Point = 34;
                calculate_Day();

                start_Day += currentDay;
                start_Point = start_Day;
                finish_Day += currentDay;
                end_Point = finish_Day;

                //좌우 끝점 설정
                if (start_Month < month)
                {
                    start_Point = currentDay;
                }
                if (month < finish_Month)
                {
                    end_Point = currentDay + day_In_Month[month];
                    if (end_Point > 35)
                        end_Point = 35;
                }

                for (int m = 0; m < 35; m++)
                {
                    if (start_Point <= m && m <= end_Point)
                    {
                        k[m] = 1;
                    }
                    else
                    {
                        k[m] = 0;
                    }
                }

                if (col_count == 0)
                {
                    for (int m = 0; m < 35; m++)
                    {
                        if (k[m] == 1)
                        {
                            label_list1[m].Text = "             ";
                            label_list1[m].BackColor = Color.DodgerBlue;
                            dataGridView_Project_List.Rows[0].Cells[4].Value = "Blue";
                        }
                        else
                        {
                            label_list1[m].Text = "";
                        }

                        f_list[m].Controls.Add(label_list1[m]);
                    }
                }
                else if (col_count == 1)
                {
                    for (int m = 0; m < 35; m++)
                    {
                        if (k[m] == 1)
                        {
                            label_list2[m].Text = "             ";
                            label_list2[m].BackColor = Color.LightSteelBlue;
                            dataGridView_Project_List.Rows[1].Cells[4].Value = "lightBlue";
                        }
                        else
                        {
                            label_list2[m].Text = "";
                        }

                        f_list[m].Controls.Add(label_list2[m]);
                    }
                }
                else if (col_count == 2)
                {
                    for (int m = 0; m < 35; m++)
                    {

                        if (k[m] == 1)
                        {
                            label_list3[m].Text = "             ";
                            label_list3[m].BackColor = Color.LightPink;
                            dataGridView_Project_List.Rows[2].Cells[4].Value = "Pink";
                        }
                        else
                        {
                            label_list3[m].Text = "";
                        }

                        f_list[m].Controls.Add(label_list3[m]);
                    }
                }
                else if (col_count == 3)
                {
                    for (int m = 0; m < 35; m++)
                    {


                        if (k[m] == 1)
                        {
                            label_list4[m].Text = "             ";
                            label_list4[m].BackColor = Color.LightYellow;
                            dataGridView_Project_List.Rows[3].Cells[4].Value = "Yellow";
                        }
                        else
                        {
                            label_list4[m].Text = "";
                        }

                        f_list[m].Controls.Add(label_list4[m]);
                    }
                }
                col_count++;
            }
        }
        

        private void Calender_Load(object sender, EventArgs e)
        {
            this.FormSendEvent(currentYear, month);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(flag == true)
            {
                dataGridView_Project_List.Rows.Clear();
                DateTime sd, ed;
                TimeSpan Ts;
                int a;
                for (int i = 0; i < start_Date.Length; i++)
                {
                    sd = DateTime.Parse(start_Date[i]);
                    ed = DateTime.Parse(end_Date[i]);
                    if (sd.Year == currentYear && ed.Year == currentYear)
                    {
                        if ((sd.Month <= month) && (month <= ed.Month))
                        {
                            a = dataGridView_Project_List.Rows.Add();
                            dataGridView_Project_List.Rows[a].Cells[0].Value = (a + 1).ToString();
                            dataGridView_Project_List.Rows[a].Cells[1].Value = start_Date[i];
                            dataGridView_Project_List.Rows[a].Cells[2].Value = end_Date[i];
                            Ts = DateTime.Parse(end_Date[i]) - DateTime.Now;
                            dataGridView_Project_List.Rows[a].Cells[3].Value = Ts.Days;
                        }
                    }
                }
                flag = false;
                invalidate_panel(k);
            }
        }
        
    }
}
