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
    public partial class eshteghalTahsilReqForm : Form
    {
        string sid;
        int isEdit = 0;
        Form main;
        List<ValidationResult> results = new List<ValidationResult>();
        public eshteghalTahsilReqForm(string sid, Form main)
        {
            this.sid = sid;
            this.main = main;
            InitializeComponent();
            
        }
        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }
        public IEnumerable<ValidationResult> Validate(studyingLiecense sl)
        {
            System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();
            DateTime today = DateTime.Now;
            string persian = pc.GetYear(today).ToString("0000-") + pc.GetMonth(today).ToString("00-") + pc.GetDayOfMonth(today).ToString("00");

            if (sl.liecenseCase1 == ""&& sl.liecenseCase2 == ""&& sl.liecenseCase3 == ""&& sl.liecenseCase4 == "")
            {
                results.Add(new ValidationResult("(باید حداقل یک مورد انتخاب شود)"));
                Console.WriteLine("wowwwww");
            }
            return results;
        }
        private void eshteghalSend_Click(object sender, EventArgs e)
        {
            if (isEdit == 0)
            {
                System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();
                DateTime today = DateTime.Now;
                string persianDate = pc.GetYear(today).ToString("0000-") + pc.GetMonth(today).ToString("00-") + pc.GetDayOfMonth(today).ToString("00");
                DateTime dt = new DateTime();
                RequestManagementEntities rme = new RequestManagementEntities();
                Random random = new Random();
                try
                {
                    results.Clear();
                    studyingLiecense sl = new studyingLiecense()
                    {
                        id = sid,
                        requestCode = random.Next(10000, 99999),
                        destinationCity = eshteghalCity.Text,
                        liecenseDetails = eshteghalDescription.Text,
                        officeDestination = eshteghalOrganization.Text,
                        studentExplanation = eshteghalStudentDescription.Text,
                        liecenseCase1 = eshteghalCase1.Text,
                        liecenseCase2 = eshteghalCase2.Text,
                        liecenseCase3 = eshteghalCase3.Text,
                        liecenseCase4 = eshteghalCase4.Text,
                        sendDate = Convert.ToDateTime(persianDate),
                        accepted = "خیر"
                    };
                    var validationResult = Validate(sl);
                    if (results.Count > 0)
                    {
                        validateForm.Text = results.ElementAt(0).ErrorMessage;
                        validateForm.Visible = true;
                    }
                    else
                    {
                        rme.studyingLiecenses.Add(sl);
                        rme.SaveChanges();
                    }
                }
                catch (Exception exception)
                {

                }
                if (results.Count == 0)
                {
                    enteghalSuccess es = new enteghalSuccess();
                    foreach (Control c in GetAll(es, typeof(Button)))
                    {
                        if (c.Name == "okBtn")
                        {
                            c.MouseDown += new MouseEventHandler(successClick);
                        }
                    }
                    es.Show();
                }
            }else if(isEdit == 1)
            {
                 
                System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();
                DateTime today = DateTime.Now;
                string persianDate = pc.GetYear(today).ToString("0000-") + pc.GetMonth(today).ToString("00-") + pc.GetDayOfMonth(today).ToString("00");
                DateTime dt = new DateTime();
                RequestManagementEntities rme = new RequestManagementEntities();
                rme.studyingLiecenses.Remove(rme.studyingLiecenses.Where(x => x.id == sid).FirstOrDefault());
                Random random = new Random();
                try
                {
                    results.Clear();
                    studyingLiecense sl = new studyingLiecense()
                    {
                        id = sid,
                        requestCode = random.Next(10000, 99999),
                        destinationCity = eshteghalCity.Text,
                        liecenseDetails = eshteghalDescription.Text,
                        officeDestination = eshteghalOrganization.Text,
                        studentExplanation = eshteghalStudentDescription.Text,
                        liecenseCase1 = eshteghalCase1.Text,
                        liecenseCase2 = eshteghalCase2.Text,
                        liecenseCase3 = eshteghalCase3.Text,
                        liecenseCase4 = eshteghalCase4.Text,
                        sendDate = Convert.ToDateTime(persianDate),
                        accepted = "خیر"
                    };
                    var validationResult = Validate(sl);
                    if (results.Count > 0)
                    {
                        validateForm.Text = results.ElementAt(0).ErrorMessage;
                        validateForm.Visible = true;
                    }
                    else
                    {
                        rme.studyingLiecenses.Add(sl);
                        rme.SaveChanges();
                    }
                }
                catch (Exception exception)
                {

                }
                if (results.Count == 0)
                {
                    enteghalSuccess es = new enteghalSuccess();
                    foreach (Control c in GetAll(es, typeof(Button)))
                    {
                        if (c.Name == "okBtn")
                        {
                            c.MouseDown += new MouseEventHandler(successClick);
                        }
                    }
                    es.Show();

                }
                this.Dispose();
            }
        }
        public void setForEdit()
        {
            editStudyingFail.Visible = true;
            isEdit = 1;
            rmLabel.Text = "ویرایش درخواست اشتغال به تحصیل";
            RequestManagementEntities rme = new RequestManagementEntities();
            eshteghalCity.Text = rme.studyingLiecenses.Where(x => x.id == sid).FirstOrDefault().destinationCity;
            eshteghalDescription.Text = rme.studyingLiecenses.Where(x => x.id == sid).FirstOrDefault().liecenseDetails;
            eshteghalOrganization.Text = rme.studyingLiecenses.Where(x => x.id == sid).FirstOrDefault().officeDestination;
            eshteghalStudentDescription.Text = rme.studyingLiecenses.Where(x => x.id == sid).FirstOrDefault().studentExplanation;
            eshteghalCase1.Text = rme.studyingLiecenses.Where(x => x.id == sid).FirstOrDefault().liecenseCase1;
            eshteghalCase2.Text = rme.studyingLiecenses.Where(x => x.id == sid).FirstOrDefault().liecenseCase2;
            eshteghalCase3.Text = rme.studyingLiecenses.Where(x => x.id == sid).FirstOrDefault().liecenseCase3;
            eshteghalCase4.Text = rme.studyingLiecenses.Where(x => x.id == sid).FirstOrDefault().liecenseCase4;
            rme.studyingLiecenses.Remove(rme.studyingLiecenses.Where(x => x.id == sid).FirstOrDefault());
        }
        void successClick(object sender, MouseEventArgs e)
        {
            foreach (Control c in GetAll(main, typeof(Panel)))
            {
                if (c.Name == "etrfPanel"|| c.Name == "rmPanel")
                {
                    main.Controls.Remove(c);
                    c.Dispose();
                }
            }
        }

        private void editStudyingFail_MouseDown(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
