using Card.Management.Application.Entity;
using Card.Management.Application.Requests.commands.AddCustomer;
using Card.Management.Infrastructure.Data;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card.Management.Application.Requests.commands
{
    public class AddCustomerCommandHandler : IRequestHandler<AddCustomerCommand, int>
    {
        private readonly CardManagementContext _context;

        public AddCustomerCommandHandler(CardManagementContext context)
        {
            _context = context;
        }
        public async Task<int> Handle(AddCustomerCommand request, CancellationToken cancellationToken)
        {
            Customers obj = new Customers();
            obj.CustomerName = request.CustomerName;
            obj.CustomerAddress = request.CustomerAddress;
            obj.Email = request.Email;
            _context.Customers.Add(obj);
            return await _context.SaveChangesAsync();
        }
    }
}
