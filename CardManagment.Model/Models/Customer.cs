using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CardManagement.Model.Models
{
    public class Customer
    {
        public static int custid = 1001;

        public string id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }

        public string Email { get; set; }


        public string PhoneNumber { get; set; }

        public Account Accounts { get; set; }


        public Customer()
        {
            id = "Cust" + custid.ToString();
            custid++;
        }




    }
}
