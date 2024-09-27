using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace Character_to_sports
{
    internal class Program
    {
        static void Main(string[] args)
        {
            here:
            Console.WriteLine("Enter the character");
            string ch=Console.ReadLine();
            switch(ch)
            {
                case "c":
                    {
                        Console.WriteLine("Cricket");
                        break;
                    }
                case "f":
                    {
                        Console.WriteLine("Football");
                        break;
                    }
                case "h":
                    {
                        Console.WriteLine("Hockey");
                        break;
                    }
                case "t":
                    {
                        Console.WriteLine("Tennis");
                        break;
                    }
                case "b":
                    {
                        Console.WriteLine("Badminton");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid input, please try again");
                        goto here;
                    }

            }
        }
    }
}
