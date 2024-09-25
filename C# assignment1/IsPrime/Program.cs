using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IsPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to be checked ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine($"The number {num} is not prime");
                    return;                
                }
            }
            Console.WriteLine($"The number {num} is prime");
        }
    }
}
            
