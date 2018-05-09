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
    public partial class LoginD : Form
    {
        public static string SetValueForText11 = "";
        public static string SetValueForText12 = "";
        public static string SetValueForText7 = "";
        public static string SetValueForText10 = "";
        public LoginD()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           SetValueForText7 = txtName.Text;
            SetValueForText12 = txtHospitalName.Text; 

        }

        private void linklblResetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ResetPassword resetpassword = new ResetPassword();
            this.Hide();
            resetpassword.Show();
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            localhost.Service1 myserver = new localhost.Service1();
            bool login;
            bool loginpassed;
            myserver.logind(txtName.Text, txtCNIC.Text,txtPassword.Text , txtHospitalName.Text, out login, out loginpassed);
            
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

        private void linklblDoctorInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void linklblPatientInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Patient patient = new Patient();
            this.Hide();
            patient.Show();
        }

        private void linklblTimings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Timings time = new Timings();
            this.Hide();
            time.Show();
        }
    }
}
