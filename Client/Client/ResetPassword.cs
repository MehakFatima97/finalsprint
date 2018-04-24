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
    public partial class ResetPassword : Form
    {
        public ResetPassword()
        {
            InitializeComponent();
        }

        private void cmdConfirmPassword_Click(object sender, EventArgs e)
        {
            localhost.Service1 myserver = new localhost.Service1();
            bool reset;
            bool resetpassed;
            //bool reseta;
            //bool resetapassed;
            //bool resetd;
            //bool resetdpassed;
            myserver.reset(txtName.Text,txtCNIC.Text, txtPassword.Text,txtConfirmPassword.Text,out reset,out resetpassed);
            myserver.reseta(txtName.Text,txtCNIC.Text, txtPassword.Text, txtConfirmPassword.Text, out reset, out resetpassed);
            myserver.resetd(txtName.Text ,txtCNIC.Text, txtPassword.Text, txtConfirmPassword.Text, out reset, out resetpassed);
            if (reset)
            {
                MessageBox.Show("password has been reset");
            }
            else
            {
                MessageBox.Show("password doesnot match");
            }


        }

        private void linklblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            localhost.Service1 myserver = new localhost.Service1();
            bool login;
            bool loginpassed;
            myserver.logina(txtCNIC.Text, txtConfirmPassword.Text,out login,out loginpassed );
            if (login)
            {
                Login l = new Login();
                this.Hide();
                l.Show();
            }
            myserver.loginp(txtCNIC.Text, txtConfirmPassword.Text, out login, out loginpassed);
            if (login)
            {
                Login l = new Login();
                this.Hide();
                l.Show();
            }
                
            else
            {
                LoginD k = new LoginD();
                this.Hide();
                k.Show();
            }
            
        }   
    }
}
