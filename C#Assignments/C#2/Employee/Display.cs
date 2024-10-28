using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C_2
{
    internal class Display
    {
        public void display(int emp_id, string emp_name, int salary,string emp_type)
        {
            Console.WriteLine($"Employee id is {emp_id} Employee name is {emp_name} Salary is{salary} Employment type is {emp_type}");
        }
        
    }
}
