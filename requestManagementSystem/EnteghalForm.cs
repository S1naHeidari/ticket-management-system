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
    public partial class EnteghalForm : Form
    {

        private int _ticks = 30;
        int isEdit = 0;
        string sid;
        Form main;
        List<ValidationResult> results = new List<ValidationResult>();
        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }
        public EnteghalForm(string sid,Form main)
        {
            this.main = main;
            this.sid = sid;
            InitializeComponent();
            transferDestinationDate.BeepOnError = true;
            Console.WriteLine("sid "+sid);
        }

        public IEnumerable<ValidationResult> Validate(transfer tf)
        {
            System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();
            DateTime today = DateTime.Now;
            string persian = pc.GetYear(today).ToString("0000-") + pc.GetMonth(today).ToString("00-") + pc.GetDayOfMonth(today).ToString("00");
            
            if (tf.destConfirmNumber.ToString().Length < 7)
            {
                Console.WriteLine("hello there!");
                results.Add(new ValidationResult("(شماره نامه دانشگاه مقصد نمیتواند کمتر از ۷ رقم باشد)"));
            }
            if (tf.destConfirmDate > Convert.ToDateTime(persian))
            {

                Console.WriteLine("yes yes!");
                results.Add(new ValidationResult("(تاریخ وارد شده باید قبل از تاریخ فعلی باشد)"));
            }
            return results;
        }
        
        
        private void transferDestinationDate_MouseClick(object sender, MouseEventArgs e)
        {
            transferDestinationDate.SelectionStart = 0;
        }

        /*private void transferSend_MouseClick(object sender, MouseEventArgs e)
        {
            
            DateTime dt = new DateTime();
            RequestManagementEntities rme = new RequestManagementEntities();
            Random random = new Random();
            try
            {
                transfer tf = new transfer()
                {
                    id = sid,
                    requestCode = random.Next(10000, 99999),
                    currentSemester = Convert.ToInt32(transferTrmNumber.Text),
                    destinationName = transferDestination.Text,
                    unitCount = int.Parse(transferUnitCount.Text),
                    destConfirmNumber = Int32.Parse(transferDestinationNumber.Text),
                    destConfirmDate = Convert.ToDateTime(transferDestinationDate.Text),

                };
                rme.transfers.Add(tf);
                
                rme.SaveChanges();
                mainPage mp = new mainPage(sid);
                this.Close();
                enteghalSuccess es = new enteghalSuccess();
                mp.Show();
                es.Show();
            }catch(Exception exc)
            {
                if (results.ElementAt(0).ErrorMessage == "(شماره نامه دانشگاه مقصد نمیتواند کمتر از ۷ رقم باشد)")
                {
                    destNumberLabel.Visible = true;

                }
                if (results.ElementAt(0).ErrorMessage == "(تاریخ وارد شده باید قبل از تاریخ فعلی باشد)")
                {
                    destNumberLabel.Visible = true;

                }
            }
        }*/
        public void setForEdit()
        {
            editReject.Visible = true;
            isEdit = 1;
            transferHeader.Text = "ویرایش درخواست انتقالی";
            RequestManagementEntities rme = new RequestManagementEntities();
            string[] allSplited = Convert.ToString(rme.transfers.Where(x => x.id == sid).FirstOrDefault().destConfirmDate.ToString()).Split(' ');
            string[] dateSplited = Convert.ToString(allSplited[0]).Split('/');
            string date = dateSplited[2] + "-" + dateSplited[1] + "-" + dateSplited[0];
            transferTrmNumber.Text = "ویرایش درخواست اشتغال به تحصیل";
            transferTrmNumber.Text = Convert.ToString(rme.transfers.Where(x => x.id == sid).FirstOrDefault().currentSemester);
            transferUnitCount.Text = rme.transfers.Where(x => x.id == sid).FirstOrDefault().unitCount.ToString();
            transferDestination.Text = rme.transfers.Where(x => x.id == sid).FirstOrDefault().destinationName;
            transferDestinationNumber.Text = rme.transfers.Where(x => x.id == sid).FirstOrDefault().destConfirmNumber.ToString();
            transferDestinationDate.Text = date;


        }
        private void transferSend_MouseClick(object sender, EventArgs e)
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
                    destNumberLabel.Visible = false;
                    destDateLabel.Visible = false;
                    transfer tf = new transfer()
                    {
                        id = sid,
                        requestCode = random.Next(10000, 99999),
                        currentSemester = Convert.ToInt32(transferTrmNumber.Text),
                        destinationName = transferDestination.Text,
                        unitCount = int.Parse(transferUnitCount.Text),
                        destConfirmNumber = Int32.Parse(transferDestinationNumber.Text),
                        destConfirmDate = Convert.ToDateTime(transferDestinationDate.Text),
                        sendDate = Convert.ToDateTime(persianDate)
                    };
                    var validationResult = Validate(tf);
                    rme.transfers.Add(tf);
                    rme.SaveChanges();
                    destDateLabel.Visible = false;
                    destNumberLabel.Visible = false;
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
                catch (Exception exception)
                {
                    if (results.Count != 0)
                    {
                        if (results.ElementAt(0).ErrorMessage == "(شماره نامه دانشگاه مقصد نمیتواند کمتر از ۷ رقم باشد)")
                        {
                            destNumberLabel.Visible = true;

                        }
                        if (results.ElementAt(0).ErrorMessage == "(تاریخ وارد شده باید قبل از تاریخ فعلی باشد)")
                        {
                            destDateLabel.Visible = true;

                        }
                        if (results.Count == 2)
                        {

                            destDateLabel.Visible = true;
                        }
                    }
                }
            }
            else if (isEdit == 1)
            {

                System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();
                DateTime today = DateTime.Now;
                string persianDate = pc.GetYear(today).ToString("0000-") + pc.GetMonth(today).ToString("00-") + pc.GetDayOfMonth(today).ToString("00");
                DateTime dt = new DateTime();
                RequestManagementEntities rme = new RequestManagementEntities();
                rme.transfers.Remove(rme.transfers.Where(x => x.id == sid).FirstOrDefault());
                Random random = new Random();
                try
                {
                    results.Clear();
                    destNumberLabel.Visible = false;
                    destDateLabel.Visible = false;
                    transfer tf = new transfer()
                    {
                        id = sid,
                        requestCode = random.Next(10000, 99999),
                        currentSemester = Convert.ToInt32(transferTrmNumber.Text),
                        destinationName = transferDestination.Text,
                        unitCount = int.Parse(transferUnitCount.Text),
                        destConfirmNumber = Int32.Parse(transferDestinationNumber.Text),
                        destConfirmDate = Convert.ToDateTime(transferDestinationDate.Text),
                        sendDate = Convert.ToDateTime(persianDate)
                    };
                    var validationResult = Validate(tf);
                    rme.transfers.Add(tf);
                    rme.SaveChanges();
                    destDateLabel.Visible = false;
                    destNumberLabel.Visible = false;
                    enteghalSuccess es = new enteghalSuccess();
                    foreach (Control c in GetAll(es, typeof(Button)))
                    {
                        if (c.Name == "okBtn")
                        {
                            c.MouseDown += new MouseEventHandler(successClick);
                        }
                    }
                    es.Show();
                    this.Dispose();
                }
                catch (Exception exception)
                {
                    if (results.Count != 0)
                    {
                        if (results.ElementAt(0).ErrorMessage == "(شماره نامه دانشگاه مقصد نمیتواند کمتر از ۷ رقم باشد)")
                        {
                            destNumberLabel.Visible = true;

                        }
                        if (results.ElementAt(0).ErrorMessage == "(تاریخ وارد شده باید قبل از تاریخ فعلی باشد)")
                        {
                            destDateLabel.Visible = true;

                        }
                        if (results.Count == 2)
                        {

                            destDateLabel.Visible = true;
                        }
                    }
                }
            }

            
        }
        void successClick(object sender, MouseEventArgs e)
        {
            foreach (Control c in GetAll(main, typeof(Panel)))
            {
                if (c.Name == "efPanel")
                {
                    main.Controls.Remove(c);
                    c.Dispose();
                }
            }
        }
        private void destNumberLabel_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(destNumberLabel, "(شماره نامه دانشگاه مقصد نمیتواند کمتر از ۷ رقم باشد)");
        }
        private void destDateLabel_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(destDateLabel, "(تاریخ وارد شده باید قبل از تاریخ فعلی باشد)");
        }
        private void transferSend_MouseClick(object sender, MouseEventArgs e)
        {

        }
        private void editReject_MouseDown(object sender, EventArgs e)
        {
            foreach (Control c in GetAll(main, typeof(Panel)))
            {
                //if (c.Name == "rmPanel")
                //{
                //    main.Controls.Remove(c);
                //    c.Dispose();
                //}
                this.Dispose();
            }
        }
    }
}
