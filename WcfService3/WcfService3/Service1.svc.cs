using System;
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
            foreach (AdminUser admin in AdminData.datalist)
            {
                if (admin.AdminCNIC == adminCNIC && admin.Adminpassword == adminpassword)
                {
                    check = true;
                }
            }
            return check;
        }

        public bool loginp(string patientCNIC, string patientpassword)
        {
            bool check = false;
            foreach (PatientUser patient in PatientData.datalist)
            {
                if (patient.PatientCNIC == patientCNIC && patient.Patientpassword == patientpassword)
                {
                    check = true;
                }
            }
            return check;

        }

        public bool logind(string doctorname, string doctorCNIC, string doctorpassword, string hospitalname)
        {
            bool check = false;
            foreach (DoctorUser doctor in DoctorData.datalist)
            {
                if (doctor.Doctorname == doctorname && doctor.DoctorCNIC == doctorCNIC && doctor.Doctorpassword == doctorpassword && doctor.Hospitalname == hospitalname)
                {
                    check = true;

                }
            }
            return check;

        }

        public List<DoctorUser> search()
        {
            return DoctorData.datalist;
        }
        public DoctorUser searchA(string doctorCNIC)
        {
        //    bool check = false;
        //   // List<DoctorData> pp = new List<DoctorData>();
            foreach (DoctorUser ac in DoctorData.datalist)
            {
                if (ac.DoctorCNIC == doctorCNIC)
                {

                   return ac;
                }

            }
        //    return check;
               return null;

        }
        public PatientUser addmed(string CNIC, string medicines, string age, string disease)
        {
            foreach (PatientUser p in PatientData.datalist)
            {
                if (p.PatientCNIC == CNIC)
                {
                    p.Medicines1 = medicines;
                    p.Disease1 = disease;
                    p.Age = age;
                    PatientData.datalist.Add(p);
                    return p;
                }
            }
            return null;
        }

        public List<PatientUser> showp()
        {
            return PatientData.datalist;
        }

        public DoctorUser searchab(string doctorName)
        {
            //    bool check = false;
            //   // List<DoctorData> pp = new List<DoctorData>();
            foreach (DoctorUser ac in DoctorData.datalist)
            {
                if (ac.Doctorname == doctorName)
                {
                    return ac;
                }

            }
            //    return check;
            return null;

        }

        public List<PatientUser> searchhistory()
        {
            return PatientData.datalist;

        }
        public DoctorUser show6(string doctorname, string department)
        {
            //    bool check = false;
            //   // List<DoctorData> pp = new List<DoctorData>();
            foreach (DoctorUser ac in DoctorData.arr)
            {
                if (ac.Doctorname == doctorname || ac.Department1 == department)
                {
                    return ac;
                }
                
            }
            //    return check;
            return null;

        }
        

        public void timings(string doctorname, string doctorCNIC, string hospitalname, string department, string day, string time, string date)
        {
            DoctorUser doctor = new DoctorUser();
            doctor.Doctorname = doctorname;
            doctor.DoctorCNIC = doctorCNIC;
            doctor.Hospitalname = hospitalname;
            doctor.Department1 = department;
            doctor.Day1 = day;
            doctor.Date1 = date;
            doctor.Time1 = time;
            DoctorData.arr.Add(doctor);
        }

        public void addinto( string age,string medicines,string disease,string CNIC)
        {
            PatientUser p = new PatientUser();
            p.Age = age;
            p.Disease1 = disease;
            p.Medicines1 = medicines;
            p.PatientCNIC = CNIC;
            PatientData.datalist.Add(p);
           
            
            
        }
        public PatientUser atlastshow(PatientUser p)
        {
            return p;
        }

        public PatientUser getp(string CNIC)
        {
            foreach (PatientUser p in PatientData.datalist)
            {
                if (p.PatientCNIC == CNIC)
                {
                    return p;
                }
            }
            return null;
        }


        public List<DoctorUser> show()
        {
            return DoctorData.arr;
        }
        public void save(string CNIC, string medicines, string age, string disease)
        {
            PatientUser p = new PatientUser();
            p.Age = age;
            p.Medicines1 = medicines;
            p.Disease1 = disease;
            PatientData.datalist.Add(p);
        }
        //public List<PatientUser> print()
        //{
        //    return PatientData.datalist;
        //}
    }
       
}
