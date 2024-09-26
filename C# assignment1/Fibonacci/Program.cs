using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = 0;
            int second = 1;
            Console.WriteLine("Enter the Fibonacci series limit");
            int n=Convert.ToInt32(Console.ReadLine());
            if (n == 0)
            {
                Console.WriteLine(first);
            }
            else if(n == 1)
            {
                Console.Write($"{first} ");
                Console.Write($"{second} ");
            }
            else
            {
                Console.Write($"{first} ");
                Console.Write($"{second} ");
                for (int i = 2; i < n; i++)
                {
                    Console.Write($"{first+second} ");

                    int temp = first;
                    first = second;
                    second = second + temp;


                }
                

            }

        }
    }
}
