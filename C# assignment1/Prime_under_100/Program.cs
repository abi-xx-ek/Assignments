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
            for (int j = 1; j <= 100; j++)
            {
                int i = 2;
                for (i=2; i <= j / 2; i++)
                {
                    if (j % i == 0)
                    {
                        break;
                    }
                }
                if (j == 1)
                {

                    Console.WriteLine("Prime numbers between 1 to 100 are:");
                }
                if (i > j/2)
                {
                    Console.Write(j);
                    Console.Write(" ");
                }
            }
        Console.WriteLine();
        }
    }
}

