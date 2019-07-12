
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringOperations
{
    class Program
    {
        private static readonly object Exit;

        static void Main(string[] args)
        {
           
            string s1,s2,s;
            int option;
            char ans;
         
                do
                {
                try
                {
                    Console.Write("1-input two strings\n2-input only one string\n");
                    Console.Write("\nInput your choice :");
                    option = Convert.ToInt32(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter first String..");
                            s1 = Convert.ToString(Console.ReadLine());
                            Console.WriteLine("Enter Second String..");
                            s2 = Convert.ToString(Console.ReadLine());
                            Console.WriteLine("compare to function compare both the given string...." + s1.CompareTo(s2));
                            Console.WriteLine("check eqality of both the given string...." + s1.Equals(s2));
                            Console.WriteLine("concat both the given string...." + string.Concat(s2));
                            break;
                        case 2:
                            Console.WriteLine("Enter one String..");
                            s = Convert.ToString(Console.ReadLine());
                            Console.WriteLine("clone function make copy of given string...." + s.Clone());
                            Console.WriteLine("contains function give true  or false value specified in the given string...." + s.Contains("gn"));
                            Console.WriteLine("check given string is last index or not...." + s.EndsWith("ehgh"));
                            Console.WriteLine("Give hashcode of given string...." + s.GetHashCode());
                            Console.WriteLine("give type of given string(eg.class system)...." + s.GetType());
                            Console.WriteLine("give type of given string...." + s.GetTypeCode());
                            Console.WriteLine("specify index position of given string...." + s.IndexOf("cd"));
                            Console.WriteLine("convert upper case to lower case  string...." + s.ToLower());
                            Console.WriteLine("convert lower case to upper case  string...." + s.ToUpper());
                            Console.WriteLine("Give length of given string...." + s.Length);
                            Console.WriteLine("insert the given substring into the string at specified index...." + s.Insert(0, "hello"));
                            Console.WriteLine("Remove the character of given string...." + s.Remove(3));
                            Console.WriteLine("replace the character of given new string to old string...." + s.Replace(s, "ddsfsfd"));
                            Console.WriteLine("give the substring of given string from specified range...." + s.Substring(3, 2));
                            break;
                        default:
                            Console.WriteLine("Invalid Input of option");
                            break;

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Input one,two options only",ex);
                }
                
                Console.WriteLine("DO you want to continue...N/Y");
                ans = Convert.ToChar(Console.ReadLine());
             } while (ans == 'Y' || ans == 'y');
            
           
        }


    
    }
}
