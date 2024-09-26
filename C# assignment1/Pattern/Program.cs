using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the height of the pattern");
            int h=Convert.ToInt32(Console.ReadLine());
            for(int i=0; i<=h;i++)
            {
                for(int j=0; j < i; j++)
                {
                    Console.Write("*");
                }
            Console.WriteLine();
            }
        }
    }
}
