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
            bool register;
            bool registerpassed;
            if (radioButtonAdmin.Checked == true)
            {
                localhost.registera(txtName.Text, txtCNIC.Text, txtPassword.Text, out register, out registerpassed);
                {
                    if (register)
                    {
                        MessageBox.Show("You r registered");
                    }
                    else
                    {
                        MessageBox.Show("u r not registered");
                    }
                }
            }

            else if (radioButtonPatient.Checked == true)
            {
                localhost.registerp(txtName.Text, txtCNIC.Text, txtPassword.Text, out register, out registerpassed);
                {
                    if (register)
                    {
                        MessageBox.Show("You r registered");
                    }
                    else
                    {
                        MessageBox.Show("u r not registered");
                    }
                }
            }

            else if (radioButtonDoctor.Checked == true)
            {
                localhost.registerd(txtName.Text, txtCNIC.Text, txtPassword.Text, txtHospitalName.Text, out register, out registerpassed);
                {
                    if (register)
                    {
                        MessageBox.Show("You r registered");
                    }
                    else
                    {
                        MessageBox.Show("u r not registered");
                    }
                }
            }
            else
            {
                MessageBox.Show("choose atleast 1 option");
            }




        }
    }
}
