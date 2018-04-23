using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService3
{
    public class AdminUser
    {
         private string adminname;
        private string adminCNIC;
        private string adminpassword;
        private string confirmpassword;

        public string Confirmpassword
        {
            get { return confirmpassword; }
            set { confirmpassword = value; }
        }

        public string Adminname
        {
            get { return adminname; }
            set { adminname = value; }
        }

        public string AdminCNIC
        {
            get { return adminCNIC; }
            set { adminCNIC = value; }
        }

        public string Adminpassword
        {
            get { return adminpassword; }
            set { adminpassword = value; }
        }
    }

    }
    
