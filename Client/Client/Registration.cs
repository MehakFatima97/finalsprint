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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void cmdRegister_Click(object sender, EventArgs e)
        {
            localhost.Service1 myserver = new localhost.Service1();
            //bool register;
            //bool registerpassed;
            if (radioButtonAdmin.Checked == true)
            {
                //myserver.registera(txtName.Text , txtCNIC.Text , txtPassword.Text);
                myserver.registera(txtName.Text, txtCNIC.Text, txtPassword.Text);
                {
                    MessageBox.Show("u r registered");
                }
            }

            else if (radioButtonPatient.Checked == true)
            {
                myserver.registerp(txtName.Text, txtCNIC.Text, txtPassword.Text);
                {
                    MessageBox.Show("u r registered");
                   
                }
            }

            else if (radioButtonDoctor.Checked == true)
            {
                myserver.registerd(txtName.Text, txtCNIC.Text, txtPassword.Text, txtHospitalName.Text);
                {
                    MessageBox.Show("u r registered");
                }
            }
            else
            {
                MessageBox.Show("choose atleast 1 option");
            }




        }

        private void radioButtonLAdmin_CheckedChanged(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void linklblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void radioButtonLPatient_CheckedChanged(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void radioButtonLDoctor_CheckedChanged(object sender, EventArgs e)
        {
            LoginD login = new LoginD();
            this.Hide();
            login.Show();
        }
    }
}
