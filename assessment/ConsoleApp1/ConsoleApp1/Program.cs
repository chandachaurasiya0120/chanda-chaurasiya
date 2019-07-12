using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a;
            //a= 10;
            //float b = (float)a;
            //Console.WriteLine("value is"+ b);
            //object a = 10;
            //Console.WriteLine(a);
            //Console.Write(a.GetType());
            //a = 10.33;
            //Console.WriteLine(a);
            //Console.Write(a.GetType());
            //a = 'c';
            //Console.WriteLine(a);
            //Console.Write(a.GetType());
            //a = "chanda";
            //Console.WriteLine(a);
            //Console.Write(a.GetType());
            //string s = "chanda";
            //object o = s;               //output=chanda
            //Console.WriteLine(o);
            // string s = "chanda";
            // object o = s;               //output=error bcz cannot convert object to string type
            //string s1= Console.WriteLine(o);
            //string s = "chanda";
            //object o = s;               //output=chanda
            //string s1 = Convert.ToString(o);
            //Console.WriteLine(o);
            //string s = "chanda";
            //object o = s;               //output=can not convert string to integer        
            //char s = 'ba';
            //object o = s;               //output= error too many character in char                                                                                                                                                                                                                
            //string s1 = Convert.ToString(o);
            //int s = 123;
            ////object o = s;               //output=can not convert int to string                                                                                                                                                                                                       
            //string s1 = o;
            ////int s =123;
            //object o = s;               //output=123 bcz compiler will understand 123 as string after conversion                                                                                                                                                                                                              
            //string s1 = Convert.ToString(o);
            //double s = 1.23;
            //object o = s;               //output=1.23 bcz compiler will understand 1.23 as string after conversion                                                                                                                                                                                                              
            //string s1 = Convert.ToString(o);
            //double s = 1.23;
            //object o = s;               //output=can not convert double to string                                                                                                                                                                                                          
            ////string s1 = (o);
            //double s = 1.23;
            //object o = s;               //output= runtime error can not convert double to char                                                                                                                                                                                                       
            //char s1 = Convert.ToChar(o);
            //double s = 1.23;
            //object o = s;               //output=1.23 bcz compiler will understand 1.23 as string after conversion                                                                                                                                                                                                              
            //string s1 = Convert.ToString(o);
            //double s = 1.23;
            ////object o = s;               //output=1.23 bcz compiler will understand 1.23 as int after conversion, double has ability to hold int and float both value                                                                                                                                                                                                           
            ////int s1 = Convert.ToInt32(o);
            //Console.WriteLine(o);
            //DateTime d = System.DateTime.Today;
            //object o = d;                   //today's date and time
            //Console.WriteLine(o);
            //object d = System.DateTime.Today;
            //object o = d;                   //today's date and time
            //Console.WriteLine(o);
            object d = System.DateTime.Today;
            object o = Convert.ToDateTime(d);                   // today's date and time
            Console.WriteLine(o);
            //object d = System.DateTime.Today;
            //object o = Convert.ToInt32(d);                   // runtime error invalid casting
            //Console.WriteLine(o);
            //object d = System.DateTime.Today;
            //object o = Convert.ToChar(d);                   // rutime error invalid casting
            //Console.WriteLine(o);
            //object d = System.DateTime.Today;
            //object o = Convert.ToString(d);                   // today's date and time
            //Console.WriteLine(o);
            //object d = System.DateTime.Today;
            //object o = Convert.ToDouble(d);                   //rutime error invalid casting
            //Console.WriteLine(o);
            Console.ReadKey();
        }
    }
}
