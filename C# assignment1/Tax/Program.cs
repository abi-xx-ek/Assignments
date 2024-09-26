using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount");
            int amt=Convert.ToInt32(Console.ReadLine());
            double tax = 0.0;
            if(amt >=0 & amt <10000)
            {
                tax = (amt * 5) / 100.0;
                Console.WriteLine($"Your tax percentage is: {5}% and tax amount is: {tax}Rupees");
            }
            else if (amt >= 10000 & amt<15000)
            {
                tax = (amt *7.5) / 100.0;
                Console.WriteLine($"Your tax percentage is: {7.5}% and tax amount is: {tax}Rupees");
            }
            else if (amt >= 15000 & amt < 20000)
            {
                tax = (amt * 10) / 100.0;
                Console.WriteLine($"Your tax percentage is: {10}% and tax amount is: {tax}Rupees");
            }
            else if (amt >= 20000 & amt < 25000)
            {
                tax = (amt * 12.5) / 100.0;
                Console.WriteLine($"Your tax percentage is: {12.5}% and tax amount is: {tax}Rupees");
            }
            else if (amt >= 25000)
            {
                tax = (amt * 15) / 100.0;
                Console.WriteLine($"Your tax percentage is: {15}% and tax amount is: {tax}Rupees");
            }
            else
            {

                Console.WriteLine("Amount should be positive");
            }
        }
    }
}
