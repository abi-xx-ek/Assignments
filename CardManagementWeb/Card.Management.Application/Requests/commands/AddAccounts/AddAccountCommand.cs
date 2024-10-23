using Card.Management.Application.Entity;
using Card.Management.Domain.Entity;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card.Management.Application.Requests.commands.AddAccounts
{
    public class AddAccountCommand:IRequest<int>
    {
        public string AccountNumber { get; set; }
        public string AccountType { get; set; }

        public double Balance { get; set; }

        public int CustomerID { get; set; }
    }
}
