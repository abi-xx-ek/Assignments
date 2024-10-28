using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_shape
{
    internal interface IShape
    {
        void CalculateArea();

        void calculateperimeter();

    }

    class rectangle : IShape
    {
        public void CalculateArea()
        {
            Console.WriteLine("Enter length of side 1");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter length of side 2");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The area is " + a * b);

        }

        public void calculateperimeter()
        {

            Console.WriteLine("Enter length of side 1");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter length of side 2");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The perimeter is " + 2 * (a + b));
        }
    }
    class triangle : IShape
    {
        public void CalculateArea()
        {
            Console.WriteLine("DO you know the height of the triangle yes or no");
            string ch = Console.ReadLine();
            if (ch.ToLower().Contains("yes"))
            {
                Console.WriteLine("Enter the base length");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter heigt");
                double h = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("The area is " + (.5 * b * h));
            }
            else
            {
                Console.WriteLine("Enter the length of side 1 ");
                double s1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the length of side 2 ");
                double s2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the length of side 3 ");
                double s3 = Convert.ToDouble(Console.ReadLine());
                double s = (s1 + s2 + s3) / 2;
                Console.WriteLine("The area is " + Math.Sqrt(s * (s - s1) * (s - s2) * (s - s3)));

            }

        }
        public void calculateperimeter()
        {
            Console.WriteLine("Enter the length of side 1 ");
            double s1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the length of side 2 ");
            double s2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the length of side 3 ");
            double s3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The perimeter is " + (s1 + s2 + s3));
        }
    }
    class Circle : IShape
    {
        public void CalculateArea()
        {
            Console.WriteLine("Enter the radius");
            double r = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The area is " + 3.14 * r * r);

        }
        public void calculateperimeter()
        {
            Console.WriteLine("Enter the radius");
            double r = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The perimeter is " + 3.14 * 2 * r);

        }

    }
}
