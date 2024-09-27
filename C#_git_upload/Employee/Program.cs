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
            List<employee> arr = new List<employee>();
            while (con.ToLower() == "yes")
            {
                Console.WriteLine("enter the employee id");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the employee name");
                string name = Console.ReadLine();
                Console.WriteLine("enter the employee salary");
                int salary = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter the employee type");
                string type = Console.ReadLine();
                
                employee obj = new employee();

                obj.setid = id;
                obj.name = name;
                obj.salary = salary;
                obj.setemp = type;
                arr.Add(obj);

         

                Console.WriteLine("do you wish to continue");
                con=Console.ReadLine();
            }
            Display dis = new Display();

            foreach(var item in arr)
            {
                dis.display(item.setid, item.name, item.salary, item.employeetype);

            }
            
        }
    }
}
