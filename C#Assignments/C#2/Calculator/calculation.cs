using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class calculation
    {
        public double Calc(double num1, double num2, int ch)
        {
            switch (ch)
            {
                case 1:
                    return num1 + num2; // Addition
                case 2:
                    return num1 - num2; // Subtraction
                case 3:
                    return num1 * num2; // Multiplication
                case 4:
                    return num1/num2;   //Division
                default: return 0;
            }
        }

    }
}
