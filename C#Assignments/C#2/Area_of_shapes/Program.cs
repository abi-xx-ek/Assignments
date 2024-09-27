using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_shapes
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
                    obj1.CalculateArea();
                }
                else if (ch == 2)
                {
                    triangle obj2 = new triangle();
                    obj2.CalculateArea();
                }
                else if (ch == 3)
                {
                    Circle obj3 = new Circle();
                    obj3.CalculateArea();
                }
                else { Console.WriteLine("invalid input"); }
                Console.WriteLine("do you wish to continue yes or no");
                con = Console.ReadLine();

            }
        }
    }




            
    class Shape
    {
        public virtual void CalculateArea()
        {
          
        }
    }
        class rectangle : Shape
        {
            public override void CalculateArea()
            {
                Console.WriteLine("Enter length of side 1");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter length of side 2");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("The area is " + a * b);

            }
        }
        class triangle : Shape
        {
        public override void CalculateArea()
        {
            Console.WriteLine("DO you know the height of the triangle yes or no");
            string ch = Console.ReadLine();
            if (ch.ToLower().Contains("yes"))
            {
                Console.WriteLine("Enter the base length");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter heigt");
                double h = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("The area is "+(.5 * b * h));
            }
            else
            {
                Console.WriteLine("Enter the length of side 1 ");
                double s1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the length of side 2 ");
                double s2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the length of side 3 ");
                double s3 = Convert.ToDouble(Console.ReadLine());
                double s=(s1+s2+s3)/2;
                Console.WriteLine("The area is "+Math.Sqrt(s * (s - s1) * (s - s2) * (s - s3)));

            }
        }
        }
        class Circle : Shape
        {
            public override void CalculateArea()
            {
                Console.WriteLine("Enter the radius");
                double r = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("The area is "+3.14 *r*r);

            }
        }

}
