using Card.Management.Domain.Entity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Card.Management.Application.Requests.commands.AddCustomer
{
    public class AddCustomerCommand : IRequest<int>
    {
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }

        public string Email { get; set; }

    }

}

