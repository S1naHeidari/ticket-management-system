using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class requestManagementGrid : Form
    {
        private int _ticks = 30;
        string username;
        private string aid;
        public requestManagementGrid(string s)
        {
            InitializeComponent();
            timer1.Start();
            username = s;
            System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();
            DateTime today = DateTime.Now;
            dateLabel.Text = pc.GetYear(today).ToString("0000/") + pc.GetMonth(today).ToString("00/") + pc.GetDayOfMonth(today).ToString("00");
            RequestManagementEntities rme = new RequestManagementEntities();
            aid = rme.attendants.Where(x => x.username == username).FirstOrDefault().id;
            nameLabel.Text = rme.attendants.Where(x => x.username == username).FirstOrDefault().firstName + " " + rme.attendants.Where(x => x.username == username).FirstOrDefault().lastName;
            aidLabel.Text = aid;
            //RequestManagementEntities rme = new RequestManagementEntities();
            transfer tf = new transfer();
            //Console.WriteLine(rme.transport_form.ToList().ElementAt(0).);
            
            
            foreach (var trans in rme.transfers.ToList())
            {
                bunifuCustomDataGrid1.Rows.Add(trans.id.ToString(), trans.currentSemester.ToString(), trans.requestCode.ToString(), trans.destinationName.ToString(), trans.unitCount.ToString(), trans.destConfirmNumber.ToString(),trans.accepted.ToString());

            }
        }

        private void requestManagementGrid_Load(object sender, EventArgs e)
        {
            // TODO: This line of code l1oads data into the 'requestManagementDataSet.transport_form' table. You can move, or remove it, as needed.
            //this.transport_formTableAdapter.Fill(this.requestManagementDataSet.transport_form);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _ticks--;
            label7.Text = _ticks.ToString();
            if (_ticks == 0)
            {
                LoginPage lp = new LoginPage();
                this.Close();
                lp.Show();

            }
        }

        private void bunifuCustomDataGrid1_Click(object sender, EventArgs e)
        {
            _ticks = 30;
            timer1.Start();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            MsgBoxExit msgex1 = new MsgBoxExit();
            msgex1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Close();
            attendantPage ap = new attendantPage(username);
            ap.Show();
        }
    }
}
