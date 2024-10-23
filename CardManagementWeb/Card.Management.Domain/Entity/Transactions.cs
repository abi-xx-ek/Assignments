using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Card.Management.Domain.Entity
{
    public class Transactions
    {
        public int Id { get; set; }
        public DateTime TransactionDate { get; set; }
        public TransactionType transactionType { get; set; }
        public double Amount { get; set; }
        public string? Description { get; set; }

        [ForeignKey("Accounts")]
        public int AccountID { get; set; }
        public Accounts Accounts { get; set; }

      

        public enum TransactionType
        {
            Deposit,
            Withdrawal,
            Transfer
        }
    }
}
