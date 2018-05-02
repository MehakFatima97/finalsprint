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
    public partial class Doctor_Info : Form
    {
        public Doctor_Info()
        {
            InitializeComponent();
        }

        private void cmdShowAll_Click(object sender, EventArgs e)
        {
            localhost.Service1 myserver = new localhost.Service1();
            BindingSource bs = new BindingSource();
            bs.DataSource = myserver.search();
            gv.DataSource = bs;
            gv.Columns[0].Visible = false;
            gv.Columns[1].Visible = false;
            gv.Columns[6].Visible = false;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void linklblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration registration = new Registration();
            this.Hide();
            registration.Show();
        }

        private void cmdShow_Click(object sender, EventArgs e)
        {
            localhost.Service1 myserver = new localhost.Service1();
            BindingSource bs = new BindingSource();
            bs.DataSource = myserver.searchA(txtCNIC.Text);
            gv.DataSource = bs;
        }
    }
}
