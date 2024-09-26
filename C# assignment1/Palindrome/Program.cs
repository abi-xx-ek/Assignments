using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number or word to be Checked");
            string num = Console.ReadLine();
            string check="";
            for (int i = num.Length - 1; i >= 0; i--)
            {
                check=check + num[i];
                
            }
            if (check == num)
            {
                Console.WriteLine($"{num} is palindrome");
            }
            else
            {
                Console.WriteLine($"{num} is not a palindrome");
            }


        }
    }
}
