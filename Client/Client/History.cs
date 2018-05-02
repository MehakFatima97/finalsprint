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
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }

        private void linklblDoctorTimeTable_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Doctor_Time_Table p = new Doctor_Time_Table();
            this.Hide();
            p.Show();
            
        }

        private void linkblBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login logind = new Login();
            this.Hide();
            logind.Show();
        }
        //public void show()
        //{

        //    //  gvPosts.AutoGenerateColumns = false;

        //    localhost.Service1 myserver = new localhost.Service1();
        //    BindingSource bs = new BindingSource();
        //    bs.DataSource = myserver.print();
        //    gv5.DataSource = bs;

        //    //gvPosts.Columns[2].Visible = false;




        ////////////////}

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCNIC_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void gv5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            
        }

        private void History_Load(object sender, EventArgs e)
        {
            //lblName.Text = Registration.SetValueForText1;
            lblCNIC.Text = Login.SetValueForText11;
        }

        private void cmdshow_Click(object sender, EventArgs e)
        {
            localhost.Service1 myserver = new localhost.Service1();
            BindingSource bs = new BindingSource();
            bs.DataSource = myserver.searchhistory(lblCNIC.Text);
            gv5.DataSource = bs;
        }
    }
}
