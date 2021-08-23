using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Linq;

namespace WindowsFormsApp2

{
    public partial class LoginPage : Form
    {
        private Boolean _dragging = false;
        //private Point _offset;
        private Point _starting_point = new Point(0,0);
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();

        public LoginPage()
        {
            this.KeyPreview = true;
            InitializeComponent();
            RequestManagementEntities rme = new RequestManagementEntities();
            /*account a = new account()
            {
                accountUsername = "9517023104",
                accountPassword = BCrypt.Net.BCrypt.HashString("an")
            };*/
            //rme.accounts.Where(x => x.accountUsername == "9517023104").FirstOrDefault().accountPassword = BCrypt.Net.BCrypt.HashString("1");
            //rme.SaveChanges();
            //rme.accounts.Add(a);
            txtPassword._TextBox.Text = "گذرواژه";
            con.ConnectionString = @"Data Source=DESKTOP-JFK8U0Q;Initial Catalog=RequestManagement;Integrated Security=True";
        }



    

        private void txtUsername_Enter_1(object sender, EventArgs e)
        {
            if (txtUsername.text.Equals("شناسه کاربری "))
            {
                txtUsername.text = "";
            }
        }

        private void txtUsername_Leave_1(object sender, EventArgs e)
        {
            if (txtUsername.text.Equals(""))
            {
                txtUsername.text = "شناسه کاربری ";
            }
        }


        private void txtPassword_Enter_1(object sender, EventArgs e)
        {
            if (txtPassword.text.Equals("گذرواژه"))
            {
                txtPassword.text = "";
                
            }
        }

        private void txtPassword_Leave_1(object sender, EventArgs e)
        {
            if (txtPassword.text.Equals(""))
            {
                txtPassword.text = "گذرواژه";
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            RequestManagementEntities rme = new RequestManagementEntities();
            account a = new account();            
            if (rme.accounts.Where(x => x.accountUsername == txtUsername.text).FirstOrDefault().accountUsername.Equals(txtUsername.text) && BCrypt.Net.BCrypt.Verify(txtPassword.text,rme.accounts.Where(x => x.accountUsername == txtUsername.text).FirstOrDefault().accountPassword))
                {
                                       
                    msgBoxCorrect msgCor = new msgBoxCorrect(txtUsername.text);
                    msgCor.Show();
                    this.Hide();                   
                }
            else
            {
                msgBoxWrong msgWor = new msgBoxWrong();
                msgWor.Show();
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            //form to show are u sure application to exit?
            MsgBoxExit msgex = new MsgBoxExit();
            msgex.Show();

        }

        private void maxBtn_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if(WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void minBtn_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void closeBtn_MouseHover(object sender, EventArgs e)
        {
           closeBtn.BackColor = Color.Red;
           // = "خروج";
        }

        private void closeBtn_MouseLeave(object sender, EventArgs e)
        {
            closeBtn.BackColor = Color.Transparent;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _starting_point = new Point(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._starting_point.X, p.Y - this._starting_point.Y);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

     
        private void panel4_MouseDown_1(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _starting_point = new Point(e.X, e.Y);
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._starting_point.X, p.Y - this._starting_point.Y);
            }
        }

        private void panel4_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void txtUsername_Load(object sender, EventArgs e)
        {
            txtUsername._TextBox.MaxLength = 25;
            if(txtUsername.text.Length >25)
            {
       
            }
        }

        private void txtPassword_Load(object sender, EventArgs e)
        {
            txtPassword._TextBox.MaxLength = 25;
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            txtUsername.text = "شناسه کاربری ";
            txtPassword.text = "گذرواژه";
            
        }
        
        private void txtUsername_KeyDown(object sender,KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && txtUsername.text != null && txtPassword.text != null)
            {
                e.Handled = true;
                btnLogin.PerformClick();
            }
        }

        private void txtPassword_KeyPress(object sender, EventArgs e)
        {
            txtPassword._TextBox.PasswordChar = '\u2022';
        }

        private void closeBtn_Click_1(object sender, EventArgs e)
        {
            MsgBoxExit m = new MsgBoxExit();
            m.Show();
        }
    }
}
