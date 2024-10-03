using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_2
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            string con = "yes";
            List<employee_2> arr = new List<employee_2>();
            while (con.ToLower() == "yes")
            {
              
                Console.WriteLine("enter the employee name");
                string name = Console.ReadLine();
                Console.WriteLine("enter the employee salary");
                double salary = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the employee type");
                string type = Console.ReadLine();
                
                employee_2 obj = new employee_2(name,salary);

                obj.setemp = type;
                arr.Add(obj);



                Console.WriteLine("do you wish to continue");
                con = Console.ReadLine();
            }
            Display_2 dis = new Display_2();
            employee_2 count = new employee_2();
            count.empcount();

            foreach (var item in arr)
            {
                dis.display(item.setid,item.setname, item.setsalary, item.setemp);

            }

        }
    }
}
