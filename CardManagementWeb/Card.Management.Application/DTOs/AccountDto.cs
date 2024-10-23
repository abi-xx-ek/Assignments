using Card.Management.Application.Entity;
using Card.Management.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card.Management.Application.DTOs
{
    public class AccountDto
    {
        public string AccountNumber { get; set; }
        public string AccountType { get; set; }

        public double Balance { get; set; }

        public int CustomerID { get; set; }

       
    }
}
