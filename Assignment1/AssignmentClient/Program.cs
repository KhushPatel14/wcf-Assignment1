/*
 * Name: Khush Umesh Patel
 * Program ID = Assignment1
 * Email: Kpatel0500@conestogac.on.ca
 * Created on Oct 16 2022
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.Assignment1ServiceClient client = new ServiceReference1.Assignment1ServiceClient();

            string choice = "";
            while (!choice.Equals("6"))
            {
                Console.WriteLine("1. Check prime numbers");
                Console.WriteLine("2. Sum of digits");
                Console.WriteLine("3. Reverse a string");
                Console.WriteLine("4. Print HTML Tags");
                Console.WriteLine("5. Sort 5 numbers");
                Console.WriteLine("6. Exit");
                Console.Write(" Select: ");
                choice = Console.ReadLine();

                switch(choice)
                {
                    case "1":
                        Console.Write("Enter number : ");
                        int n1 = int.Parse(Console.ReadLine());


                        bool n3 = client.checkPrime(n1);
                        if(n3 == true)
                        {
                            Console.WriteLine("Is a prime number");
                        }
                        else
                        {
                            Console.WriteLine("Not a prime number");
                        }
                        break;
                    case "2":
                        Console.Write("Enter number : ");
                        int number = int.Parse(Console.ReadLine());


                        int sum = client.sumDigits(number);
                        Console.WriteLine("Result is " + sum);
                       
                        break;
                    case "3":
                        Console.Write("Enter string: ");
                        string str = Console.ReadLine();
                        string result = client.reverseString(str);

                        Console.WriteLine("The reversed string is: "  + result);
                        break;
                    case "4":
                        Console.Write("Please enter TAG: ");
                        string tag = Console.ReadLine();
                        Console.Write("Please enter DATA: ");
                        string data = Console.ReadLine();

                        string res = client.joinString(tag, data);

                        Console.WriteLine("The html code is: " + res);

                        break;

                    case "5":

                        bool repeat = true;
                        do
                        {
                            Console.Write("Select Sort Type(aesc/desc): ");
                            string sortType = Console.ReadLine();
                            


                            if (sortType == "aesc")
                            {

                                Console.Write("Enter numbers: ");

                                int[] arr1 = new int[5];
                                for (int i = 0; i < arr1.Length; i++)
                                {
                                    Console.Write("number - {0} : ", i);
                                    arr1[i] = Convert.ToInt32(Console.ReadLine());
                                }
                                int[] result3 = client.sortNumber(arr1);

                                Console.WriteLine("\nSorted List");
                                for (int i = 0; i < result3.Length; i++)
                                {
                                    Console.WriteLine(result3[i] + " ");
                                }
                            }
                            else if (sortType == "desc")
                            {
                                Console.Write("Enter numbers: ");

                                int[] arr1 = new int[5];
                                for (int i = 0; i < arr1.Length; i++)
                                {
                                    Console.Write("number - {0} : ", i);
                                    arr1[i] = Convert.ToInt32(Console.ReadLine());
                                }
                                int[] result3 = client.sortNumberDesc(arr1);

                                Console.WriteLine("\nSorted List");
                                for (int i = 0; i < result3.Length; i++)
                                {
                                    Console.WriteLine(result3[i] + " ");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Wrong input");
                                repeat = true;
                            }
                        }
                        while (repeat == false);

                        break;
                }
            }

        }
    }
}
