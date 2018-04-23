using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService3
{
    public class DoctorUser
    {
        private string hospitalname;
        private string doctorCNIC;
        private string doctorname;
        private string doctorpassword;
        private string confirmpassword;

        public string Confirmpassword
        {
            get { return confirmpassword; }
            set { confirmpassword = value; }
        }


        public string Hospitalname
        {
            get { return hospitalname; }
            set { hospitalname = value; }

        }

        public string DoctorCNIC
        {
            get { return doctorCNIC; }
            set { doctorCNIC = value; }

        }

        public string Doctorname
        {
            get { return doctorname; }
            set { doctorname = value; }

        }

        public string Doctorpassword
        {
            get { return doctorpassword; }
            set { doctorpassword = value; }

        }
    }
}