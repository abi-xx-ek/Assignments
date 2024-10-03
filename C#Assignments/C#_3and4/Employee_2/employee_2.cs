using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace C_2
{
    internal class employee_2
    {
        public static int id=1000;
        public int setid
        {
            get;set;

        }
        public double setsalary
        {
            get;set;

        }
        public string setname
        {
            get; set;

        }
        public string setemp
        {
            get; set;
        }

        public employee_2()
        {
        
        }
        public employee_2(int id)
        {
            setid = id;
        }
        public employee_2(int id,string name) : this(id) 
        {
            setname = name;
        }
        public employee_2(string name,double salary) :this(id++,name) 
        {
            setsalary = salary;
        }

        public void empcount()
        {
            Console.WriteLine("Total number of employees is " + (id - 1000));
        }
        
    }
}
