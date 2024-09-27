using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number ");
            string num = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                sum = sum + Convert.ToInt32(num[i].ToString()); 
            }
            Console.WriteLine("The sum  is " + sum);
        }
    }
}
