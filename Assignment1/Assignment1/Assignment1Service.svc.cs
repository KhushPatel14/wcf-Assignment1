using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Assignment1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IAssignment1Service
    {
        public bool checkPrime(int n1)
        {
            for (int i = 2; i < n1; i++)
                if (n1 % i == 0)
                    return false;
            return true;
        }

        public string joinString(string s1, string s2)
        {
            string result = "<" + s1 + ">"  + s2 + "<" +  s1 + ">";

            return result;
        }

        public string reverseString(string n1)
        {
            int length = 0;
            string reverse = "";
            length = n1.Length - 1;
            while (length >= 0)
            {
                reverse = reverse + n1[length];
                length--;
            }
            return reverse;
        }

        public int[] sortNumber(int[] a1)
        {
            Array.Sort(a1);
            return a1;
        }

        public int[] sortNumberDesc(int[] a1)
        {
            Array.Sort(a1);
            Array.Reverse(a1);
            return a1;
        }

        public int sumDigits(int n1)
        {
            int sum = 0;
            sum += n1 % 10;
            sum += n1 / 10;

            return sum;
        }
    }
}
