
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace interface_shape
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string con = "yes";
            while (con.ToLower().Contains("yes"))
            {
                Console.WriteLine("1.Rectangle");
                Console.WriteLine("2.Triangle");
                Console.WriteLine("3.Circle");
                Console.WriteLine("Enter your choice");
                int ch = Convert.ToInt32(Console.ReadLine());
                if (ch == 1)
                {
                    rectangle obj1 = new rectangle();
                    Console.WriteLine("Do you want to calculate 1.area or 2.perimeter");
                    Console.WriteLine("Enter your choice");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    if (choice == 1)
                    {
                        obj1.CalculateArea();
                    }
                    else if (choice == 2)
                    {
                        obj1.calculateperimeter();
                    }
                    else
                    {
                        Console.WriteLine("wrong choice");
                    }

                }
                else if (ch == 2)
                {
                    triangle obj2 = new triangle();
                    Console.WriteLine("Do you want to calculate 1.area or 2.perimeter");
                    Console.WriteLine("Enter your choice");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    if (choice == 1)
                    {
                        obj2.CalculateArea();
                    }
                    else if (choice == 2)
                    {
                        obj2.calculateperimeter();
                    }
                    else
                    {
                        Console.WriteLine("wrong choice");
                    }

                }
                else if (ch == 3)
                {
                    Circle obj3 = new Circle();
                    Console.WriteLine("Do you want to calculate 1.area or 2.perimeter");
                    Console.WriteLine("Enter your choice");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    if (choice == 1)
                    {
                        obj3.CalculateArea();
                    }
                    else if (choice == 2)
                    {
                        obj3.calculateperimeter();
                    }
                    else
                    {
                        Console.WriteLine("wrong choice");
                    }

                }
                else { Console.WriteLine("invalid input"); }
                Console.WriteLine("do you wish to continue yes or no");
                con = Console.ReadLine();

            }
        }
    }
}

