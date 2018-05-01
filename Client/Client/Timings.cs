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
    public partial class Timings : Form
    {
        public Timings()
        {
            InitializeComponent();
        }

        private void cmdGenerate_Click(object sender, EventArgs e)
        {
            Time_Table time = new Time_Table();
            this.Hide();
            time.Show();
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            LoginD d = new LoginD();
            this.Hide();
            d.Show();
            
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            localhost.Service1 myserver = new localhost.Service1();
              myserver.timings(txtName.Text, txtCNIC.Text, txtHospitalName.Text,comboBoxDepartment.Text, comboBoxDay.Text, txtTime.Text,txtDate.Text);
                    MessageBox.Show("Timings are saved");
        }
    }
}
