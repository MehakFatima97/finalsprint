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
            localhost.reset(txtName.Text,txtCNIC.Text, txtPassword.Text,txtConfirmPassword.Text, out reset, out resetpassed);
            localhost.reseta(txtCNIC.Text, txtPassword.Text, txtConfirmPassword.Text, out reset, out resetpassed);
            localhost.resetd(txtCNIC.Text, txtPassword.Text, txtConfirmPassword.Text, out reset, out resetpassed);
            if (reset)
            {
                MessageBox.Show("password has been reset");
            }
            else
            {
                MessageBox.Show("password doesnot match");
            }


        }
    }
}
