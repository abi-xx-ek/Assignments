using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace largest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string con = "yes";
            while(con.ToLower().Contains("yes"))
            { 
                Console.WriteLine("Enter the first num");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the second num");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the third num");
                int num3 = Convert.ToInt32(Console.ReadLine());
                if (num1 > num2)
                {
                    if (num1 > num3)
                    {
                        Console.WriteLine(num1 + " Is the largest");
                    }
                    else
                    {
                        Console.WriteLine(num3 + " Is the largest");
                    }
                }
                else if (num2 > num3)
                {
                    Console.WriteLine(num2 + " Is the largest");

                }
                else
                {
                    Console.WriteLine(num3 + " Is the largest");
                }
                Console.WriteLine("Do you wish to continue: yes or no");
                con = Console.ReadLine();
            }
        }
    }
}
