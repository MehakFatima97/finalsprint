using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService3
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);
        [OperationContract]
        bool reset(string patientname, string patientCNIC, string patientpassword, string confirmpassword);
        [OperationContract]
        bool reseta(string adminname, string adminCNIC, string adminpassword, string confirmpassword);
        [OperationContract]
        bool resetd(string doctorname, string doctorCNIC, string doctorpassword, string confirmpassword);
        [OperationContract]
        void registera(string adminname, string adminCNIC, string adminpassword);
        [OperationContract]
        void registerp(string patientname, string patientCNIC, string patientpassword);
        [OperationContract]
        void registerd(string doctorname, string doctorCNIC, string doctorpassword, string hospitalname);
        [OperationContract]
        bool logina(string adminCNIC, string adminpassword);
        [OperationContract]
        bool loginp(string patientCNIC, string patientpassword);
        [OperationContract]
        bool logind(string doctorname,string doctorCNIC, string doctorpassword, string hospitalname);
        
        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
