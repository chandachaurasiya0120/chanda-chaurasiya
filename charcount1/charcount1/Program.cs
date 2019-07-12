using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace charcount1
{
    class Program
    {
        public static void Main(string[] args)
        {
            try {
                Console.WriteLine("Enter Number of persons");
                int i = Convert.ToInt32(Console.ReadLine());
                int count = 0, count1 = 0;
                for (int j = 1; j <= i; j++)
                {
                    Console.WriteLine("Enter Mele And Female");
                    char c = Convert.ToChar(Console.ReadLine());
                    if (c == 'm')

                    {
                        count++;
                    }
                    else if (c == 'f')
                    {
                        count1++;
                    }
                }
                Console.WriteLine("Number of Male is:" + count);
                Console.WriteLine("Number of Female is:" + count1);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
