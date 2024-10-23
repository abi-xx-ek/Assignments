using Card.Management.Application.Entity;
using Card.Management.Domain.Entity;
using Card.Management.Infrastructure.Data;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Card.Management.Application.Requests.commands.AddAccounts
{
    public class AddAccountHandler : IRequestHandler<AddAccountCommand, int>
    {
       
        private readonly CardManagementContext _context;
        public AddAccountHandler(CardManagementContext context) 
        {
            _context = context; 
        }
        public async Task<int> Handle(AddAccountCommand request, CancellationToken cancellationToken)
        {
           Accounts obj = new Accounts();
            obj.AccountNumber = request.AccountNumber;
            obj.AccountType = request.AccountType;
            obj.Balance = request.Balance;
            obj.CustomerID= request.CustomerID;
            _context.Accounts.Add(obj);
            return await _context.SaveChangesAsync();
        }
    }
}
