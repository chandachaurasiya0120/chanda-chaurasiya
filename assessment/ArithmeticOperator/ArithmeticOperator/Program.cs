using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a;
                do
                {
                     int option;
                    char ans;
                    Console.WriteLine("1.Arithmetic Operators\n2.Relational Operators\n3.Logical Operators\n4.Bitwise Operators\n5.Assignment Operators");
                    Console.WriteLine("Enter your Choice");
                    option = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("===================================================");
                    switch (option)
                    {
                        case 1:
                            try
                            {
                                do
                                {
                                    Double num1, num2, result;
                                    int n;
                                    Console.WriteLine("1.Addition\n2.Subtraction\n3.Multipliction\n4.Division\ns5.Modulo\n6.Increment\n7.Decrement");
                                    Console.WriteLine("Enter your choice");
                                    n = Convert.ToInt32(Console.ReadLine());
                                    void input()
                                    {
                                        Console.WriteLine("Enter First Number");
                                        num1 = Convert.ToDouble(Console.ReadLine());
                                        Console.WriteLine("Enter Second Number");
                                        num2 = Convert.ToDouble(Console.ReadLine());
                                    }
                                    switch (n)
                                    {
                                        case 1:
                                            input();
                                            result = num1 + num2;
                                            Console.WriteLine("addition of first and second number is :" + result);
                                            break;
                                        case 2:
                                            input();
                                            result = num1 - num2;
                                            Console.WriteLine("Subtraction of first and second number is :" + result);
                                            break;
                                        case 3:
                                            input();
                                            result = num1 * num2;
                                            Console.WriteLine("Multiplicationof first and second number is :" + result);
                                            break;
                                        case 4:
                                            try
                                            {
                                                input();
                                                result = num1 / num2;
                                                Console.WriteLine("Division of first and second number is :" + result);
                                            }
                                            catch (DivideByZeroException e)
                                            {
                                                Console.WriteLine(e.Message);
                                            }
                                            break;
                                        case 5:
                                            input();
                                            result = num1 % num2;
                                            Console.WriteLine("Modulo of first and second number is :" + result);
                                            break;
                                        case 6:
                                            Console.WriteLine("Enter First Number");
                                            num1 = Convert.ToDouble(Console.ReadLine());
                                            result = num1++;
                                            Console.WriteLine("Increment of first number is :" + result);
                                            break;
                                        case 7:
                                            Console.WriteLine("Enter First Number");
                                            num1 = Convert.ToDouble(Console.ReadLine());
                                            result = num1--;
                                            Console.WriteLine("Decrement of first number is :" + result);
                                            break;
                                        default:
                                            Console.WriteLine("Invalid Input");
                                            break;
                                    }
                                    Console.Write("do you want to continue?Y/N");
                                    ans = Convert.ToChar(Console.ReadLine());
                                } while (ans == 'Y' || ans == 'y');
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            Console.ReadLine();
                            break;
                        case 2:
                            try
                            {
                                do
                                {
                                    Double num1, num2, result;
                                    int n;
                                    Console.WriteLine("1.Equal\n2.Not equal\n3.Greater than\n4.Less than\ns5.Greater or Equal \n6.Less or equal\n");
                                    Console.WriteLine("Enter your choice");
                                    n = Convert.ToInt32(Console.ReadLine());
                                    void Input()
                                    {
                                        Console.WriteLine("Enter First Number");
                                        num1 = Convert.ToDouble(Console.ReadLine());
                                        Console.WriteLine("Enter Second Number");
                                        num2 = Convert.ToDouble(Console.ReadLine());
                                    }
                                    switch (n)
                                    {
                                        case 1:
                                            Input();
                                            result = Convert.ToDouble(num1 == num2);
                                            Console.WriteLine("Numbers are equal :" + result);
                                            break;
                                        case 2:
                                            Input();
                                            result = Convert.ToDouble(num1 != num2);
                                            Console.WriteLine("Numbers are not equal :" + result);
                                            break;
                                        case 3:
                                            Input();
                                            result = Convert.ToDouble(num1 > num2);
                                            Console.WriteLine("First number is greater than second number :" + result);
                                            break;
                                        case 4:
                                            Input();
                                            result = Convert.ToDouble(num1 < num2);
                                            Console.WriteLine("First number is Less than second number :" + result);
                                            break;
                                        case 5:
                                            Input();
                                            result = Convert.ToDouble(num1 >= num2);
                                            Console.WriteLine("First number is greater than or equals to second number :" + result);
                                            break;
                                        case 6:
                                            Input();
                                            result = Convert.ToDouble(num1 <= num2);
                                            Console.WriteLine("First number is Less than or equals to second number :" + result);
                                            break;
                                        default:
                                            Console.WriteLine("Invalid Input");
                                            break;
                                    }
                                    Console.Write("do you want to continue?Y/N");
                                    ans = Convert.ToChar(Console.ReadLine());
                                } while (ans == 'Y' || ans == 'y');
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            Console.ReadLine();
                            break;
                        case 3:
                            try
                            {
                                do
                                {
                                    Double num1, num2;
                                    Boolean result;
                                    int n;
                                    Console.WriteLine("1.Logical AND(&&)\n2.Logical OR(||)\n3.Logical NOT(!\n");
                                    Console.WriteLine("Enter your choice");
                                    n = Convert.ToInt32(Console.ReadLine());
                                    void Input()
                                    {
                                        Console.WriteLine("Enter First Number");
                                        num1 = Convert.ToDouble(Console.ReadLine());
                                        Console.WriteLine("Enter Second Number");
                                        num2 = Convert.ToDouble(Console.ReadLine());
                                    }
                                    switch (n)
                                    {
                                        case 1:
                                            Input();
                                            result = (num1 > num2) && (num1 < num2);
                                            Console.WriteLine("Numbers are equal :" + result);
                                            break;
                                        case 2:
                                            Input();
                                            result = (num1 > num2) || (num1 < num2);
                                            Console.WriteLine("Numbers are not equal :" + result);
                                            break;
                                        case 3:
                                            Input();
                                            result = (num1 != num2);
                                            Console.WriteLine("First number is Not equal to second number :" + result);
                                            break;
                                        default:
                                            Console.WriteLine("Invalid Input");
                                            break;
                                    }
                                    Console.Write("do you want to continue?Y/N");
                                    ans = Convert.ToChar(Console.ReadLine());
                                } while (ans == 'Y' || ans == 'y');

                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            Console.ReadLine();
                            break;
                        case 4:
                            try
                            {
                                do
                                {
                                    Double num1, num2;
                                    Boolean result;
                                    int n;
                                    Console.WriteLine("1.Binary AND(&&)\n2.Binary OR(||)\n3.Binary XOR");
                                    Console.WriteLine("Enter your choice");
                                    n = Convert.ToInt32(Console.ReadLine());
                                    void Input()
                                    {
                                        Console.WriteLine("Enter First Number");
                                        num1 = Convert.ToDouble(Console.ReadLine());
                                        Console.WriteLine("Enter Second Number");
                                        num2 = Convert.ToDouble(Console.ReadLine());
                                    }
                                    switch (n)
                                    {
                                        case 1:
                                            Input();
                                            result = (num1 > num2) & (num1 < num2);
                                            Console.WriteLine("Binary AND :" + result);
                                            break;
                                        case 2:
                                            Input();
                                            result = (num1 > num2) | (num1 < num2);
                                            Console.WriteLine("Binary OR :" + result);
                                            break;
                                        case 3:
                                            Input();
                                            result = (num1 > num2) ^ (num1 < num2);
                                            Console.WriteLine("Binary XOR :" + result);
                                            break;
                                        default:
                                            Console.WriteLine("Invalid Input");
                                            break;
                                    }
                                    Console.Write("do you want to continue?Y/N");
                                    ans = Convert.ToChar(Console.ReadLine());
                                } while (ans == 'Y' || ans == 'y');

                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            Console.ReadLine();
                            break;
                        case 5:
                            try
                            {
                                do
                                {
                                    Double num1, num2, result=0;
                                    int n;
                                    Console.WriteLine("1.Assignment Operator\n2.Add AND assignment operator\n3.Subtract AND assignment operator\n4.Multiply AND assignment operator\ns5.Divide AND assignment operator");
                                    Console.WriteLine("Enter your choice");
                                    n = Convert.ToInt32(Console.ReadLine());
                                    void Input()
                                    {
                                        Console.WriteLine("Enter First Number");
                                        num1 = Convert.ToDouble(Console.ReadLine());
                                        Console.WriteLine("Enter Second Number");
                                        num2 = Convert.ToDouble(Console.ReadLine());
                                    }
                                    switch (n)
                                    {
                                        case 1:
                                            Input();
                                            result = num1;
                                            Console.WriteLine("Assignment Operator:" + result);
                                            break;
                                        case 2:
                                            Input();
                                            result += Convert.ToDouble(num1 + num2);
                                            Console.WriteLine("Subtract AND assignment operator :" + result);
                                            break;
                                        case 3:
                                            Input();
                                            result -= Convert.ToDouble(num1 + num2);
                                            Console.WriteLine("Subtract AND assignment operator :" + result);
                                            break;
                                        case 4:
                                            Input();
                                            result *= Convert.ToDouble(num1 + num2);
                                            Console.WriteLine("Multiply AND assignment operator :" + result);
                                            break;
                                        case 5:
                                            Input();
                                            result /= Convert.ToDouble(num1 + num2);
                                            Console.WriteLine("Divide AND assignment operator :" + result);
                                            break;

                                        default:
                                            Console.WriteLine("Invalid Input");
                                            break;
                                    }
                                    Console.Write("do you want to continue?Y/N");
                                    ans = Convert.ToChar(Console.ReadLine());
                                } while (ans == 'Y' || ans == 'y');
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            Console.ReadLine();
                            break;
                        default:
                            Console.WriteLine("Invalid Option");
                            break;
                    }
                    Console.Write("do you want to continue?Y/N");
                a = Convert.ToInt32(Console.ReadLine());
            } while (a == 1) ;
        }
        catch (Exception e)
        {
          Console.WriteLine(e.Message);
        }
           Console.ReadLine();
      }  
   }
}

