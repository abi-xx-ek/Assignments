using Card.Management.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Card.Management.Domain.Entity.Transactions;

namespace Card.Management.Application.DTOs
{
    public class TransactionDto
    {
        public DateTime TransactionDate { get; set; }
        public TransactionType transactionType { get; set; }
        public double Amount { get; set; }
        public string? Description { get; set; }
        public int AccountID { get; set; }
    }
}
