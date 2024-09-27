using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to be reversed");
            string num=Console.ReadLine();
            for(int i=num.Length-1;i>=0 ;i--)
            {
                Console.Write(num[i]);

            }
            Console.WriteLine();
        }
    }
}
