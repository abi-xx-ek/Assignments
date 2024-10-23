using Card.Management.Application.Methods;
using Card.Management.Domain.Entity;
using Card.Management.Infrastructure.Data;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card.Management.Application.Requests.commands.AddTransactions
{
    public class AddTransactionCommandHandler:IRequestHandler<AddTransactionCommand,int>
    {
        private readonly CardManagementContext _context;
        public AddTransactionCommandHandler(CardManagementContext context)
        {
            _context = context;
        }

        


        async Task<int> IRequestHandler<AddTransactionCommand, int>.Handle(AddTransactionCommand request, CancellationToken cancellationToken)
        {
            Transactions obj = new Transactions();
            obj.TransactionDate = request.TransactionDate;
            obj.transactionType = request.transactionType;
            obj.Amount = request.Amount;
            obj.AccountID = request.AccountID;
            _context.Transactions.Add(obj);
            TransactionBalanceUpdate t = new TransactionBalanceUpdate(_context);

            t.UpdateBalance(obj, request.AccountID);
            return await _context.SaveChangesAsync();
        }
    }
}
