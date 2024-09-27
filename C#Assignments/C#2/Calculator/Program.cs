using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string con = "yes";
            while (con.ToLower().Contains("yes"))
            {
                Console.WriteLine("1.Addition");
                Console.WriteLine("2.Substraction");
                Console.WriteLine("3.multiplication");
                Console.WriteLine("4.Division");
                
                Console.WriteLine("Enter the operation to be performed");
                int ch = Convert.ToInt32(Console.ReadLine());
                if (ch < 1 | ch > 4)
                {
                    Console.WriteLine("worng choice");
                    Console.WriteLine("do you wish to continue yes or no");
                    con = Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("Enter the first number");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the second number");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    calculation obj = new calculation();
                    double result = obj.Calc(num1, num2, ch);
                    Console.WriteLine(result);
                    Console.WriteLine("do you wish to continue yes or no");
                    con = Console.ReadLine();

                }
            }
                



        }
           

    }
}

