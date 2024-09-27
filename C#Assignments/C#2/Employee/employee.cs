using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_2
{
    internal class employee
    {
        public string name;
        public int salary;
        public string employeetype;



        public int setid
        {
            get;set;
            
        }
        public int setsalary
        {
            get { return salary; }
            set { salary = value; }

        }
        public string setname
        {
            get { return name; }
            set { name = value; }

        }
        public string setemp
        {
            get { return employeetype; }
            set { employeetype = value; }
        }
    }
}
