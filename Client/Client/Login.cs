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
            localhost.logina(txtCNIC.Text, txtPassword.Text, out login, out loginpassed);
            localhost.loginp(txtCNIC.Text, txtPassword.Text, out login, out loginpassed);
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
}
