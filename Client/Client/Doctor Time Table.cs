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
    public partial class Doctor_Time_Table : Form
    {
        public Doctor_Time_Table()
        {
            InitializeComponent();
        }

        private void linklblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login l = new Login();
            this.Hide();
            l.Show();
        }

        private void Doctor_Time_Table_Load(object sender, EventArgs e)
        {
            History DoctorInfo = new History();
            this.Hide();
            DoctorInfo.Show();
        }
    }
}
