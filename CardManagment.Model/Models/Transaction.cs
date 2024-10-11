using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CardManagement.Model.Models
{
    public class Transaction
    {


        public string id { get; set; }
        public DateTime TransactionDate { get; set; }
        public TransactionType transactionType { get; set; }
        public double Amount { get; set; }
        public string Description { get; set; }
        public Account Accounts { get; set; }

        public enum TransactionType
        {
            Deposit,
            Withdrawal,
            Transfer
        }
        public Transaction()
        {
            
        }
        public Transaction(int txnid)
        {
            txnid = txnid + 1000;
            id = "Txn" + txnid.ToString();
            txnid++;
        }
    }

}

