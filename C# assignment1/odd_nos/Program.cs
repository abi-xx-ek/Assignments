using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odd_nos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while(i<=50)
            {
                if(i%2!=0)
                {
                    Console.WriteLine(i);
                }
            i++;
            }
        }
    }
}
