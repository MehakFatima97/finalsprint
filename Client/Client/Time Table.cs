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
    public partial class Time_Table : Form
    {
        
        public Time_Table()
        {
            InitializeComponent();
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            Timings time = new Timings();
            this.Hide();
            time.Show();
        }

        private void cmdShow_Click(object sender, EventArgs e)
        {
            localhost.Service1 myserver = new localhost.Service1();
            BindingSource bs = new BindingSource();
            bs.DataSource = myserver.show();
            gv1.DataSource = bs;
            gv1.Columns[3].Visible = false;
           // gv1.Columns[2].Visible = false;
            gv1.Columns[4].Visible = false;
        }

        private void gv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             
        }
    }
}
