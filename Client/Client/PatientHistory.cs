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
    public partial class PatientHistory : Form
    {
        public PatientHistory()
        {
            InitializeComponent();
        }

        private void cmdLogout_Click(object sender, EventArgs e)
        {
            LoginD logind = new LoginD();
            this.Hide();
            logind.Show();
        }

        private void cmdNewPatient_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();
            this.Hide();
            patient.Show();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            
        }

        private void linklblShowHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void linklblTimeTable_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Doctor_Time_Table DoctorInfo = new Doctor_Time_Table();
            this.Hide();
            DoctorInfo.Show();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            //localhost.Service1 myserver = new localhost.Service1();
            //myserver.timings(txtName.Text, txtCNIC.Text, txtHospitalName.Text, comboBoxDepartment.Text, comboBoxDay.Text, txtTime.Text, txtDate.Text);
            //MessageBox.Show("saved");
        }
    }
}
