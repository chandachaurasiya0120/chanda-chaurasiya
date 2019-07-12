using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                int num;
                Console.WriteLine("Enter Number for Multiplication");
                num = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("=====================================");
                Console.WriteLine("Multiplication of Number\n");

                for (int i = 1; i <= 10; i++)
                {

                    Console.WriteLine("{0}*{1}={2}", num, i, num * i);
                }

               
            }
            catch(FormatException e)
            {
                Console.WriteLine("ERROR:-Input numbers only",e);
            }

            Console.ReadKey();
        }
    }
}
