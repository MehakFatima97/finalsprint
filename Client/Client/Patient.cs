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
        public static string SetValueForText1 = "";

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

        private void txtPatientCNIC_TextChanged(object sender, EventArgs e)
        {
            SetValueForText1 = txtPatientCNIC.Text;
        }
    }
}
