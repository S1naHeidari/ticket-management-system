using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class studentEditPanel : Form
    {
        string sid;
        editWasSuccessful ews = new editWasSuccessful();
        Form main;
        RequestManagementEntities rme = new RequestManagementEntities();
        public studentEditPanel(string sid, Form main)
        {
            InitializeComponent();
            StringBuilder sb = new StringBuilder();
            this.sid = sid;
            this.main = main;
            //RequestManagementEntities rme = new RequestManagementEntities();
            //sid = rme.students.Where(x => x.username == username).FirstOrDefault().id;
            string editBirthdayFirst = Convert.ToString(rme.students.Where(x => x.username == sid).FirstOrDefault().birthday);
            string[] allSplited = Convert.ToString(editBirthdayFirst).Split(' ');
            string[] dateSplited = Convert.ToString(allSplited[0]).Split('/');
            string date = dateSplited[2] + "/" + dateSplited[1] + "/" + dateSplited[0];
            editBirthday.Text = date;
            fatherNameTB.Text = rme.students.Where(x => x.username == sid).FirstOrDefault().fatherName;
            editPhoneMasked.Text = rme.students.Where(x => x.username == sid).FirstOrDefault().phoneNumber;
            educationFieldTB.Text = rme.students.Where(x => x.username == sid).FirstOrDefault().educationField;
            educationFieldTB.Text = rme.students.Where(x => x.username == sid).FirstOrDefault().educationField;

        }
        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
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


        private void editPhoneMasked_MouseClick(object sender, MouseEventArgs e)
        {
            editPhoneMasked.SelectionStart = 0;
        }

        private void editBirthday_MouseClick(object sender, MouseEventArgs e)
        {
            editBirthday.SelectionStart = 0;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            foreach (Control c in GetAll(main, typeof(Panel)))
            {
                if (c.Name == "editMainPanel")
                {
                    main.Controls.Remove(c);
                    c.Dispose();
                }
            }
        }
        List<ValidationResult> results = new List<ValidationResult>();
        public IEnumerable<ValidationResult> Validate(student tf)
        {
            System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();
            DateTime today = DateTime.Now;
            string persian = pc.GetYear(today).ToString("0000-") + pc.GetMonth(today).ToString("00-") + pc.GetDayOfMonth(today).ToString("00");

            if (educationFieldTB.Text.Equals(""))
            {
                results.Add(new ValidationResult("(مقطع تحصیلی نمیتواند خالی باشد)"));
            }
            return results;
        }
        public IEnumerable<ValidationResult> Validate(account a)
        {
            System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();
            DateTime today = DateTime.Now;
            string persian = pc.GetYear(today).ToString("0000-") + pc.GetMonth(today).ToString("00-") + pc.GetDayOfMonth(today).ToString("00");
            if (passTB.Text != "" && confirmPassTB.Text != "" && confirmPassTB.Text != passTB.Text)
            {
                results.Add(new ValidationResult("(گذرواژه ها با هم همخوانی ندارند)"));
            }
            return results;
        }
        private void submitBtn_Click(object sender, EventArgs e)
        {
            int count = 0;
            results.Clear();
            StringBuilder sb = new StringBuilder();
            RequestManagementEntities rmeAccount = new RequestManagementEntities();
            editEduFieldLabel.Visible = false;
            editPassword.Visible = false;
            try
            {
                string date = editBirthday.Text;
                //string[] allSplited = Convert.ToString(editBirthdayFirst).Split(' ');
                //string[] dateSplited = Convert.ToString(allSplited[0]).Split('/');
                //string date = dateSplited[2] + "-" + dateSplited[1] + "-" + dateSplited[0];
                //editBirthday.Text = date;
                rme.students.Where(x => x.username == sid).FirstOrDefault().fatherName = fatherNameTB.Text;
                string phone = editPhoneMasked.Text;
                phone = phone.Remove(3, 1);
                rme.students.Where(x => x.username == sid).FirstOrDefault().phoneNumber = phone;
                rme.students.Where(x => x.username == sid).FirstOrDefault().birthday = Convert.ToDateTime(date);
                rme.students.Where(x => x.username == sid).FirstOrDefault().educationField = educationFieldTB.Text;
                var validationResult = Validate(rme.students.Where(x => x.username == sid).FirstOrDefault());
                if (results.Count > 0)
                {
                    count = 1;
                    editEduFieldLabel.Visible = true;
                    results.Clear();
                }
                var validationResult2 = Validate(rme.accounts.Where(x => x.accountUsername == sid).FirstOrDefault());
                if (results.Count >0)
                {
                    count = 1;
                    editPassword.Visible = true;
                    results.Clear();
                }
                if(count == 0)
                {
                    if (confirmPassTB.Text!="" && passTB.Text!="")
                    {
                        
                        rmeAccount.accounts.Where(x => x.accountUsername == sid).FirstOrDefault().accountPassword = BCrypt.Net.BCrypt.HashString(confirmPassTB.Text);
                        rmeAccount.SaveChanges();
                    }
                    
                    
                    foreach (Control c in GetAll(ews, typeof(Button)))
                    {
                        if (c.Name == "success_YES")
                        {
                            c.MouseDown += new MouseEventHandler(successClick);
                        }
                        if (c.Name == "success_NO")
                        {
                            c.MouseDown += new MouseEventHandler(failsClick);
                        }
                    }
                    ews.Show();
                }
            }catch(Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
        void successClick(object sender, MouseEventArgs e)
        {
            foreach (Control c in GetAll(main, typeof(Panel)))
            {
                if (c.Name == "editPanel")
                {
                    rme.SaveChanges();
                    main.Controls.Remove(c);
                    c.Dispose();
                    ews.Dispose();
                }
            }

            foreach (Control c in GetAll(main, typeof(TextBox)))
            {
                Console.WriteLine("heellloooo"+c.Name);
            }
        }
        void failsClick(object sender, MouseEventArgs e)
        {
            foreach (Control c in GetAll(main, typeof(Panel)))
            {
                if (c.Name == "editPanel")
                {
                    main.Controls.Remove(c);
                    c.Dispose();
                    ews.Dispose();
                }
            }
        }

        private void editEduFieldLabel_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(editEduFieldLabel, "(مقطع تحصیلی نمیتواند خالی باشد)");
        }

        private void editPassword_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(editPassword, "(گذرواژه ها با هم همخوانی ندارند)");
        }

    }

}
