using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApp2
{

    public partial class mainPage : Form
    {
        int sendRequestResize = 53;
        int isSendRequestOpened = 0;
        private int _ticks = 60;
        private string username;
        private string sid;
        LinkedList<Control> panelHandler = new LinkedList<Control>();
        public mainPage(string s)
        {
            InitializeComponent();
            this.Draggable(true);
            username = s;
            sessionTimer.Start();
            System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();
            DateTime today = DateTime.Now;
            studentDateLabel.Text = pc.GetYear(today).ToString("0000/") + pc.GetMonth(today).ToString("00/") + pc.GetDayOfMonth(today).ToString("00");
            RequestManagementEntities rme = new RequestManagementEntities();
            sid = rme.students.Where(x => x.username == username).FirstOrDefault().id;
            StudentNameLabel.Text = rme.students.Where(x => x.username == username).FirstOrDefault().firstName + " " + rme.students.Where(x => x.username == username).FirstOrDefault().lastName;
            studentIdLabel.Text = sid;
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            _ticks--;
            studentSessionLabel.Text = _ticks.ToString();
            if (_ticks == 0)
            {
                LoginPage lp = new LoginPage();
                this.Close();
                lp.Show();
            }
        }

        private void mainPage_MouseClick(object sender, MouseEventArgs e)
        {
            _ticks = 30;
            sessionTimer.Start();
        }

        private void mainPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            _ticks = 30;
            sessionTimer.Start();
        }

        private void closeBtn_Click_1(object sender, EventArgs e)
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


        private void timer2_Tick(object sender, EventArgs e)
        {
            if (sendRequestResize > 126)
            { dropDownTimer.Stop(); }
            else
            {
                this.dropDownPanel.Size = new Size(this.dropDownPanel.Size.Width, sendRequestResize);
                sendRequestResize += 5;
            }
        }
        private void sendRequestPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (isSendRequestOpened == 1)
            {
                dropDownTimer.Stop();
                sendRequestResize = 51;
                this.dropDownPanel.Size = new Size(this.dropDownPanel.Size.Width, sendRequestResize);
                isSendRequestOpened = 0;
            }
            else
            {
                dropDownTimer.Start();
                isSendRequestOpened = 1;
            }
        }

        private void transBtn_MouseClick(object sender, MouseEventArgs e)
        {
            studentBackBtn.Visible = true;
            EnteghalForm ef = new EnteghalForm(sid,this);

            foreach (Control c in GetAll(ef, typeof(Panel)))
            {
                if (c.Name.Equals("efPanel"))
                {


                    //panelHandler.RemoveLast();
                    if (panelHandler.Count() > 1)
                    {
                        var second = panelHandler.ElementAt(1);
                        panelHandler.Remove(second);
                        second.Dispose();

                    }
                    panelHandler.AddLast(c);

                    mainStudentPanel.Controls.Add(panelHandler.Last());
                    panelHandler.Last().Dock = DockStyle.Fill;
                    //Console.WriteLine(panelHandler.ElementAt(0).Name+" "+panelHandler.ElementAt(1).Name);
                    Console.WriteLine(panelHandler.ElementAt(0).Name);
                    foreach (Control sc in c.Controls)
                    {
                        sc.MouseDown += new MouseEventHandler(OnrmPanelClick);
                    }

                    break;

                }

            }
            ef.Dispose();
            //this.Close();
        }

        private void eshteghalBtn_Click(object sender, EventArgs e)
        {
            studentBackBtn.Visible = true;
            eshteghalTahsilReqForm etrf = new eshteghalTahsilReqForm(sid,this);

            foreach (Control c in GetAll(etrf, typeof(Panel)))
            {
                if (c.Name.Equals("etrfPanel"))
                {
                    if (panelHandler.Count() > 1)
                    {
                        var second = panelHandler.ElementAt(1);
                        panelHandler.Remove(second);
                        second.Dispose();

                    }
                    panelHandler.AddLast(c);

                    mainStudentPanel.Controls.Add(panelHandler.Last());
                    panelHandler.Last().Dock = DockStyle.Fill;
                    //Console.WriteLine(panelHandler.ElementAt(0).Name+" "+panelHandler.ElementAt(1).Name);
                    Console.WriteLine(panelHandler.ElementAt(0).Name);
                    foreach (Control sc in c.Controls)
                    {
                        sc.MouseDown += new MouseEventHandler(OnrmPanelClick);
                    }
                    break;

                }

            }
            etrf.Dispose();
        }

        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }
        List<Panel> panelStack = new List<Panel>();
        int index;
        /*eshteghalTahsilReqForm etrf = new eshteghalTahsilReqForm();

            foreach(Control c in GetAll(etrf, typeof(Panel)))
            {
                if (c.Name.Equals("etrfPanel"))
                {
                    mainStudentPanel.Controls.Add(c);
                    c.Dock = DockStyle.Fill;
                    break;
                }
}*/
        private void mainPage_Load(object sender, EventArgs e)
        {
            panelHandler.AddLast(mainStudentPanel);
        }

        private void requestManagementPanel_MouseDown(object sender, MouseEventArgs e)
        {
            studentBackBtn.Visible = true;
            requestManagement rm = new requestManagement(sid,this);
            foreach (Control c in GetAll(rm, typeof(Panel)))
            {
                if (c.Name.Equals("rmPanel"))
                {
                    if (panelHandler.Count() > 1)
                    {
                        var second = panelHandler.ElementAt(1);
                        panelHandler.Remove(second);
                        second.Dispose();

                    }
                    panelHandler.AddLast(c);

                    mainStudentPanel.Controls.Add(panelHandler.Last());
                    panelHandler.Last().Dock = DockStyle.Fill;
                    //Console.WriteLine(panelHandler.ElementAt(0).Name+" "+panelHandler.ElementAt(1).Name);
                    Console.WriteLine(panelHandler.ElementAt(0).Name);

                    foreach (Control sc in c.Controls)
                    {
                        sc.MouseDown += new MouseEventHandler(OnrmPanelClick);
                    }
                    break;
                }
            }
            rm.Dispose();
        }
        void OnrmPanelClick(object sender, MouseEventArgs e)
        {
            _ticks = 60;
            sessionTimer.Start();
        }

        private void mainPage_MouseDown(object sender, MouseEventArgs e)
        {
            studentBackBtn.Visible = true;
            studentEditPanel se = new studentEditPanel(sid,this);

            foreach (Control c in GetAll(se, typeof(Panel)))
            {
                if (c.Name.Equals("editPanel"))
                {
                    if (panelHandler.Count() > 1)
                    {
                        var second = panelHandler.ElementAt(1);
                        panelHandler.Remove(second);
                        second.Dispose();

                    }
                    panelHandler.AddLast(c);
                    mainStudentPanel.Controls.Add(panelHandler.Last());
                    panelHandler.Last().Dock = DockStyle.Fill;
                    //Console.WriteLine(panelHandler.ElementAt(0).Name+" "+panelHandler.ElementAt(1).Name);
                    //Console.WriteLine(panelHandler.ElementAt(0).Name);
                    foreach (Control sc in c.Controls)
                    {
                        sc.MouseDown += new MouseEventHandler(OnrmPanelClick);
                    }
                    break;

                }
            }
            se.Dispose();
        }

        private void studentBackBtn_Click(object sender, EventArgs e)
        {
            studentBackBtn.Visible = false;
            mainStudentPanel.Controls.Remove(panelHandler.Last());
            panelHandler.RemoveLast();
        }

        private void studentExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginPage lp = new LoginPage();
            lp.Show();
        }

    }
    public static class ControlExtension
    {
        // TKey is control to drag, TValue is a flag used while dragging
        private static Dictionary<Control, bool> draggables =
                   new Dictionary<Control, bool>();
        private static System.Drawing.Size mouseOffset;

        /// <summary>
        /// Enabling/disabling dragging for control
        /// </summary>
        public static void Draggable(this Control control, bool Enable)
        {
            if (Enable)
            {
                // enable drag feature
                if (draggables.ContainsKey(control))
                {   // return if control is already draggable
                    return;
                }
                // 'false' - initial state is 'not dragging'
                draggables.Add(control, false);

                // assign required event handlersnnn
                control.MouseDown += new MouseEventHandler(control_MouseDown);
                control.MouseUp += new MouseEventHandler(control_MouseUp);
                control.MouseMove += new MouseEventHandler(control_MouseMove);
            }
            else
            {
                // disable drag feature
                if (!draggables.ContainsKey(control))
                {  // return if control is not draggable
                    return;
                }
                // remove event handlers
                control.MouseDown -= control_MouseDown;
                control.MouseUp -= control_MouseUp;
                control.MouseMove -= control_MouseMove;
                draggables.Remove(control);
            }
        }
        static void control_MouseDown(object sender, MouseEventArgs e)
        {
            mouseOffset = new System.Drawing.Size(e.Location);
            // turning on dragging
            draggables[(Control)sender] = true;
        }
        static void control_MouseUp(object sender, MouseEventArgs e)
        {
            // turning off dragging
            draggables[(Control)sender] = false;
        }
        static void control_MouseMove(object sender, MouseEventArgs e)
        {
            // only if dragging is turned on
            if (draggables[(Control)sender] == true)
            {
                // calculations of control's new position
                System.Drawing.Point newLocationOffset = e.Location - mouseOffset;
                ((Control)sender).Left += newLocationOffset.X;
                ((Control)sender).Top += newLocationOffset.Y;
            }
        }
    }
}