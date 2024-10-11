using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardManagement.Model.Models
{
    public class Account
    {
        public string id { get; set; }
        public string AccountNumber { get; set; }
        public string AccountType { get; set; }

        public  double Balance { get; set; }

        public Account() { }

        public Account(int accno)
        {
            accno = accno + 1000;
            id = "Acc" + accno.ToString();

        }

    }
}
