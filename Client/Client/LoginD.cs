﻿using System;
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
        public LoginD()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linklblResetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            localhost.Service1 myserver = new localhost.Service1();
            bool login;
            bool loginpassed;
            localhost.logind(txtName.Text, txtCNIC.Text,txtPassword.Text , txtHospitalName.Text, out login, out loginpassed);
            
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