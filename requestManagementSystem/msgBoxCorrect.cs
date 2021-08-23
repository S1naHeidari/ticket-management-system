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
    public partial class msgBoxCorrect : Form
    {
        private string username;

        public msgBoxCorrect(string s)
        {
            InitializeComponent();
            username = s;

        }

        private void msgBoxCorrect_Load(object sender, EventArgs e)
        {

        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            RequestManagementEntities rme = new RequestManagementEntities();
            student std = new student();

            if (rme.students.Where(x => x.username == username).Count() == 1)
            {
                mainPage mp = new mainPage(username);
                mp.Show();
                this.Close();
            }
            else if(rme.attendants.Where(x => x.username == username).Count() == 1)
            {
                attendantPage ap = new attendantPage(username);
                ap.Show();
                this.Close();
            }
            
        }
    }
}
