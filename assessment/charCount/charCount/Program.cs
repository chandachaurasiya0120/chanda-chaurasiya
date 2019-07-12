using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharCount
{
    class Program
    {

        public static void Main()
        {
            Console.WriteLine("1.Character count\n2.Input Character And count");
           Console.WriteLine("Enter your choice");
           int option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("==============================================");
            switch (option)
            {
                case 1:
                    char[] c = { 'm', 'f', 'm', 'f', 'f', 'm', 'f', 'm', 'f' };
                    int count = 0, count1 = 0;
                    foreach (char ch in c)
                    {
                        if (ch == 'm')
                        {
                            count++;
                        }
                        else if (ch == 'f')
                        {
                            count1++;
                        }
                        else
                        {
                            Console.WriteLine();
                        }

                    }
                    Console.WriteLine("Number of Male:"+count);
                    Console.WriteLine("Number of Female:"+count1);
                    Console.ReadKey();
                    break;
                case 2:
                    try
                    {
                        Console.WriteLine("Enter Number of persons");
                        int i = Convert.ToInt32(Console.ReadLine());
                        int countm = 0, countf = 0;
                        for (int j = 1; j <= i; j++)
                        {
                            
                            Console.WriteLine("Enter Mele And Female");
                            char ch = Convert.ToChar(Console.ReadLine());
                            if (ch == 'm')

                            {
                                countm++;
                            }
                            else if (ch == 'f')
                            {
                                countf++;
                            }
                        }
                        Console.WriteLine("Number of Male is:" + countm);
                        Console.WriteLine("Number of Female is:" + countf);
                    }
                    catch(FormatException f)
                    {
                        Console.WriteLine(f.Message);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    Console.ReadLine();
                    break;
            }

                
               
         
        }
    }
}
