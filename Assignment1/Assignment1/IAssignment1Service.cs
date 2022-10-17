using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Assignment1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IAssignment1Service
    {
        [OperationContract]
        bool checkPrime(int n1);
        [OperationContract]
        int sumDigits(int n1);
        [OperationContract]
        string reverseString(string n1);
        [OperationContract]
        string joinString(string s1, string s2);
        [OperationContract]
        int [] sortNumber(int [] a1);
        [OperationContract]
        int [] sortNumberDesc(int [] a1);

        
    }
}
