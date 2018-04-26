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
            Doctor_Info DoctorInfo = new Doctor_Info();
            this.Hide();
            DoctorInfo.Show();
        }
    }
}
