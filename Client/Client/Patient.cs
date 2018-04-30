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
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }

        private void cmdNext_Click(object sender, EventArgs e)
        {
            PatientHistory patienthistory = new PatientHistory();
            this.Hide();
            patienthistory.Show();
        }
    }
}
