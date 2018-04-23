﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService3
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public bool reseta(string adminname, string adminCNIC, string adminpassword, string confirmpassword)
        {
            bool check = false;
            //string returnMsg = null;
            //AdminUser a = new AdminUser();
            foreach (AdminUser admin in AdminData.datalist)
            {
                if (admin.Adminname == adminname && admin.AdminCNIC == adminCNIC)
                {
                    //admin.Adminpassword = adminpassword;
                    //admin.AdminCNIC = adminCNIC;
                    if (adminpassword == confirmpassword)
                    {
                        check = true;
                    }
                    //else
                    //{
                    //    return true;
                    //}

                }


            }
            return check;


        }

        public bool resetd(string doctorname, string doctorCNIC, string doctorpassword, string confirmpassword)
        {
            bool check = false;
            //DoctorUser d = new DoctorUser();
            foreach (DoctorUser doctor in DoctorData.datalist)
            {
                if (doctor.Doctorname == doctorname && doctor.DoctorCNIC == doctorCNIC)
                {
                    //doctor.Doctorpassword = doctorpassword;
                    //doctor.DoctorCNIC = doctorCNIC;
                    if (doctorpassword == confirmpassword)
                    {
                        check = true;
                    }
                    //else
                    //{
                    //    return true;
                    //}

                }

            }
            return check;


        }

        public bool reset(string patientname, string patientCNIC, string patientpassword, string confirmpassword)
        {
            bool check = false;
            // PatientUser p = new PatientUser();
            foreach (PatientUser patient in PatientData.datalist)
            {
                if (patient.Patientname == patientname && patient.PatientCNIC == patientCNIC)
                {
                    //patient.Patientpassword = patientpassword;
                    //patient.PatientCNIC = patientCNIC;
                    if (patientpassword == confirmpassword)
                    {
                        check = true;

                    }
                    //else
                    //{
                    //    return true;
                    //}
                }


            }
            return check;

        }

        public void registera(string adminname, string adminCNIC, string adminpassword)
        {
            AdminUser admin = new AdminUser();
            admin.Adminname = adminname;
            admin.Adminpassword = adminpassword;
            admin.AdminCNIC = adminCNIC;
            AdminData.datalist.Add(admin);

        }

        public void registerp(string patientname, string patientCNIC, string patientpassword)
        {
            PatientUser patient = new PatientUser();
            patient.Patientname = patientname;
            patient.PatientCNIC = patientCNIC;
            patient.Patientpassword = patientpassword;
            PatientData.datalist.Add(patient);
        }

        public void registerd(string doctorname, string doctorCNIC, string doctorpassword, string hospitalname)
        {
            DoctorUser doctor = new DoctorUser();
            doctor.Doctorname = doctorname;
            doctor.DoctorCNIC = doctorCNIC;
            doctor.Doctorpassword = doctorpassword;
            doctor.Hospitalname = hospitalname;
            DoctorData.datalist.Add(doctor);
        }

        public bool logina(string adminCNIC, string adminpassword)
        {
            bool check = false;
            foreach(AdminUser admin in AdminData.datalist)
            {
                if(admin.AdminCNIC == adminCNIC && admin.Adminpassword == adminpassword)
                {
                    check = true;
                }
            }
            return check;
        }

        public bool loginp(string patientCNIC, string patientpassword)
        {
            bool check = false;
            foreach(PatientUser patient in PatientData.datalist)
            {
                if(patient.PatientCNIC == patientCNIC && patient.Patientpassword == patientpassword )
                {
                    check = true;
                }
            }
            return check;
  
        }

       public bool logind(string doctorname,string doctorCNIC, string doctorpassword, string hospitalname)
        {
            bool check = false;
           foreach(DoctorUser doctor in DoctorData.datalist)
           {
               if(doctor.Doctorname == doctorname && doctor.DoctorCNIC == doctorCNIC && doctor.Doctorpassword == doctorpassword && doctor.Hospitalname== hospitalname)
               {
                   check = true;
 
               }
           }
           return check;

        }

       
    }
}
