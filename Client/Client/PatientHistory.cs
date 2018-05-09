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
        public static string SetValueForText1 = "";
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

            localhost.Service1 myserver = new localhost.Service1();
            BindingSource bs = new BindingSource();
            //BindingSource b = new BindingSource();
            bs.DataSource = myserver.searchhistory();
            
            gv6.DataSource = bs;

          
            
            //gv6.Columns[0].Visible = false;
            //gv6.Columns[1].Visible = false;
            //gv6.Columns[4].Visible = false;
            //gv6.Columns[2].Visible = false;
            //gv6.Columns[3].Visible = false;
           // gv6.Columns[].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            gv6.Rows.Add( LoginD.SetValueForText7);


        }

        private void linklblTimeTable_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Doctor_Time_Table DoctorInfo = new Doctor_Time_Table();
            this.Hide();
            DoctorInfo.Show();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            localhost.Service1 myserver = new localhost.Service1();
            BindingSource bs = new BindingSource();
            //BindingSource b = new BindingSource();
            bs.DataSource = myserver.addmed(label2.Text, txtmedicines.Text, txtage.Text, txtdisease.Text);

            gv6.DataSource = bs;

        }

        private void txtCNIC_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCNIC_Click(object sender, EventArgs e)
        {
            label2.Text = Patient.SetValueForText1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PatientHistory_Load(object sender, EventArgs e)
        {
            label2.Text = Patient.SetValueForText1;
            lblName.Text = LoginD.SetValueForText7;
            lblHospital.Text = LoginD.SetValueForText12;
            showPosts();
        }

        private void gv6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
          
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {

            localhost.Service1 myserver = new localhost.Service1();

            //localhost.PatientUser p = new localhost.PatientUser();
            //p.Age = txtage.Text;
            //p.Medicines1 = txtmedicines.Text;
            //p.Disease1 = txtdisease.Text;
            //p.PatientCNIC = Patient.SetValueForText1;
           // myserver.addinto(p,label2.Text);
            //BindingSource bs = new BindingSource();
            //BindingSource b = new BindingSource();
             myserver.addinto(txtage.Text,txtmedicines.Text,txtdisease.Text,label2.Text);
             MessageBox.Show("saved");

            //gv6.DataSource = bs;


            //showPosts();
            
            


        }

        public void showPosts()
        {

            //  gvPosts.AutoGenerateColumns = false;

            localhost.Service1 myserver = new localhost.Service1();
            BindingSource bs = new BindingSource();
            bs.DataSource = myserver.getp(label2.Text);
            gv6.DataSource = bs;

            //gv6.Columns[2].Visible = false;




        }
    }
}
