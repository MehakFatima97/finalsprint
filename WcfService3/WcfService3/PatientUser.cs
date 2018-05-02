using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;
using System.Web;

namespace WcfService3
{
    [DataContract]
    public class PatientUser
    {
        private string patientname;
        private string patientCNIC;
        private string patientpassword;
        private string confirmpassword;
        private string age;
        private string disease;




        [DataMember]
        public string Age
        {
            get { return age; }
            set { age = value; }
        }
        private string Disease;
        [DataMember]
        public string Disease1
        {
            get { return Disease; }
            set { Disease = value; }
        }
        private string Medicines;
        [DataMember]

        public string Medicines1
        {
            get { return Medicines; }
            set { Medicines = value; }
        }

        public string Confirmpassword
        {
            get { return confirmpassword; }
            set { confirmpassword = value; }
        }
        [DataMember]
        public string Patientname
        {
            get { return patientname; }
            set { patientname = value; }
        }
        [DataMember]
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