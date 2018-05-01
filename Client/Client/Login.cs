using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            localhost.Service1 myserver = new localhost.Service1();
            bool login;
            bool loginpassed;
            //bool loginp;
            //bool loginppassed;
            myserver.logina(txtCNIC.Text, txtPassword.Text, out login, out loginpassed);
            if (login)
            {
                {
                    MessageBox.Show("valid user");
                }
            }
            else
            {
                myserver.loginp(txtCNIC.Text, txtPassword.Text, out login, out loginpassed);
                if (login)
                {
                    MessageBox.Show("valid user");
                }
                else
                {
                    MessageBox.Show("invalid user");
                }

            }
            
        }

        private void linklblRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration registration = new Registration();
            this.Hide();
            registration.Show();
        }

        private void linklblResetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ResetPassword resetpassword = new ResetPassword();
            this.Hide();
            resetpassword.Show();
        }

        private void linklblDoctorinfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            localhost.Service1 myserver = new localhost.Service1();
            bool login;
            bool loginpassed;
            
            myserver.logina(txtCNIC.Text, txtPassword.Text, out login, out loginpassed);
            if (login)
            {
                Doctor_Info DoctorInfo = new Doctor_Info();
                this.Hide();
                DoctorInfo.Show();
            }
            
        }

        private void linklblTimeTable_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
             Doctor_Time_Table DoctorInfo = new Doctor_Time_Table();
            this.Hide();
            DoctorInfo.Show();
        }

        private void linklblHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            localhost.Service1 myserver = new localhost.Service1();
            bool login;
            bool loginpassed;
            myserver.loginp(txtCNIC.Text, txtPassword.Text, out login, out loginpassed);
            if (login)
            {
                History DoctorInfo = new History();
                this.Hide();
                DoctorInfo.Show();

                
                //gv.Columns[0].Visible = false;
               // gv.Columns[1].Visible = false;
               // gv.Columns[6].Visible = false;

            }
        }
    }
}
