using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maths.Operations_;

namespace calculator_using_library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArithmeticOperation aobj = new ArithmeticOperation();
            RelationalOperation robj = new RelationalOperation();


            string con = "yes";
            while (con.ToLower() == "yes")
            {
                Console.WriteLine("1.Addition");
                Console.WriteLine("2.Substraction");
                Console.WriteLine("3.which is greater");
                Console.WriteLine("4.check equal or not");
                Console.WriteLine("enter the operation to be performed");
                int i = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("enter the first number");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("enter the second number");
                double num2 = Convert.ToDouble(Console.ReadLine());


                if (i == 1)
                {
                    double a = aobj.add(num1, num2);
                    Console.WriteLine($"sum of {num1} and {num2} is {a}");
                }
                else if (i == 2)
                {
                    double a = aobj.sub(num1, num2);
                    Console.WriteLine($"difference of {num1} and {num2} is {a}");
                }
                else if (i == 3)
                {
                    bool a = robj.greaterthan(num1, num2);
                    if (a)
                    {
                        Console.WriteLine($"{num1} is greaterthan {num2}");

                    }
                    else
                    {
                        Console.WriteLine($"{num2} is greaterthan {num1}");

                    }
                }
                else if (i == 4)
                {
                    bool a = robj.equal(num1, num2);
                    if (a)
                    {
                        Console.WriteLine($"{num1} equal to {num2}");

                    }
                    else
                    {
                        Console.WriteLine($"{num2} not equal to {num1}");

                    }
                }
                else 
                {
                    Console.WriteLine("wrong choice");
                }
                Console.WriteLine("do you wish to continue");
                con = Console.ReadLine();


            }
        }
    }
}
