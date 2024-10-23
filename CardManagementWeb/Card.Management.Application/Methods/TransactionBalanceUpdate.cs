using Card.Management.Domain.Entity;
using Card.Management.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Card.Management.Application.Methods
{
    public class TransactionBalanceUpdate
    {
        private readonly CardManagementContext _context;

        public TransactionBalanceUpdate(CardManagementContext context)
        {
            _context = context;
        }

        public void UpdateBalance(Transactions Transaction,int AccountID)
        {
            var account = _context.Accounts.FirstOrDefault(x => x.Id==(AccountID)); ;
            if(Transaction.transactionType==Transactions.TransactionType.Deposit)
            {
                account.Balance = account.Balance + Transaction.Amount;
            }
            else
            {
                account.Balance = account.Balance - Transaction.Amount;

            }
            _context.Accounts.Update(account);
            _context.SaveChanges();
        }
    }
}
