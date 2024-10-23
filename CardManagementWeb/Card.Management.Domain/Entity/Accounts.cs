using Card.Management.Application.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card.Management.Domain.Entity
{
    public class Accounts
    {
        public int Id { get; set; } 

        public string AccountNumber { get; set; }

        public string AccountType { get; set; }

        public double Balance { get; set; }

        [ForeignKey("Customers")]

        public int CustomerID { get; set; }
        public  Customers Customer { get; set; }
        public List<Transactions> transactions { get; set; }

    }
}
