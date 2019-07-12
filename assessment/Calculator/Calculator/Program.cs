using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Calculator
{
    class Calci
    {
        static void Main(string[] args)
        {
            try {
                      Double num1, num2;
                      int option;
                      char ans;
                  do
                 {
                    
                        Console.Write("\n===================================================================\n");
                        Console.Write("1-Addition.\n2-Substraction.\n3-Multiplication.\n4-Division.\n5-Exit.\n");
                        Console.Write("\nInput your choice :");
                        option = Convert.ToInt32(Console.ReadLine());
                       void EnterNumbers()
                     {
                        Console.Write("Enter the first number :");
                        num1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter the second number :");
                        num2 = Convert.ToDouble(Console.ReadLine());
                     }

                        switch (option)
                        {
                            case 1:
                                EnterNumbers();
                                Console.Write("The Addition of {0} and  {1} is: {2}\n", num1, num2, num1 + num2);
                            break;
                            case 2:
                               EnterNumbers();
                               Console.Write("The Substraction of {0} and  {1} is: {2}\n", num1, num2, num1 - num2);
                            break;
                            case 3:
                                   EnterNumbers();
                                   Console.Write("The Multiplication of{0} and  {1} is: {2}\n", num1, num2, num1 * num2);
                            break;
                            case 4:
                                 EnterNumbers(); 
                                 Console.Write("The Division of {0} and  {1} is: {2}\n", num1, num2, num1 / num2);
                            break;
                            case 5:
                                break;
                            default:
                                Console.Write("Input correct option\n");
                                break;
                        }
                    Console.Write("do you want to continue?Y/N");
                    ans = Convert.ToChar(Console.ReadLine());
                   } while (ans == 'Y' || ans == 'y');
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();

        }      

    }
}
