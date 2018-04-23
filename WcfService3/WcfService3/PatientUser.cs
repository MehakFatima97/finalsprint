using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService3
{
    public class PatientUser
    {
        private string patientname;
        private string patientCNIC;
        private string patientpassword;
        private string confirmpassword;

        public string Confirmpassword
        {
            get { return confirmpassword; }
            set { confirmpassword = value; }
        }

        public string Patientname
        {
            get { return patientname; }
            set { patientname = value; }
        }

        public string PatientCNIC
        {
            get { return patientCNIC; }
            set { patientCNIC = value; }
        }

        public string Patientpassword
        {
            get { return patientpassword; }
            set { patientpassword = value; }
        }
    }
}