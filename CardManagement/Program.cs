using CardManagement;
using CardManagement.Model.Models;
using CardManagment.Model.Data;
using Microsoft.EntityFrameworkCore;

using (CardManagmentContext context = new CardManagmentContext())
{

    List<Account> account = new List<Account>()
        {

        new Account()
        {

            AccountNumber = "100210",
            AccountType = "savings",
            Balance = 10000
        },
        new Account()
        {
            AccountNumber = "798745",
            AccountType = "savings",
            Balance = 24500
        }
        };
    context.Accounts.AddRange(account);
    context.SaveChanges();




    List<Transaction> transactions = new List<Transaction>()
        {
        new Transaction()
        {
            TransactionDate = DateTime.Now,
            transactionType = Transaction.TransactionType.Transfer,
            Amount = 1500,
            Description = "transfering amt",
            Accounts = account[0]
        },
        new Transaction
        {
            TransactionDate = new DateTime(2023, 10, 5),
            transactionType = Transaction.TransactionType.Deposit,
            Amount = 2000,
            Description = "depositing",
            Accounts = account[1]

        }

    };


    context.Transactions.AddRange(transactions);
    context.SaveChanges();




    List<Customer> customers = new List<Customer>()
        {
            new Customer()
            {
                CustomerName = "abhi",
                CustomerAddress = "trivandtum",
                Email = "abhishek@gmail.com",
                PhoneNumber = "7356735678",
                Accounts = account[0]
            },
            new Customer()
            {
                CustomerName = "hari",
                CustomerAddress = "kollam",
                Email = "hari@gmail.com",
                PhoneNumber = "7845125637",
                Accounts = account[1]
            }
        };


    context.Customers.AddRange(customers);
    context.SaveChanges();

}

using (CardManagmentContext context = new CardManagmentContext())
{
    List<Customer> customers = context.Customers.ToList();
    foreach (var customer in customers)
    {
        Console.WriteLine($"customer id : {customer.id}\ncustomer name : {customer.CustomerName}\ncustomer email : {customer.Email}");
        Console.WriteLine();
    }

    Console.WriteLine();


    List<Customer> cust_acc = context.Customers.Include(x=>x.Accounts).ToList();

    foreach (var customer in cust_acc)
    {
        Console.WriteLine($"acoount id : {customer.Accounts.id}\naccount number : {customer.Accounts.AccountNumber}\naccount type : {customer.Accounts.AccountType} \nbalance : {customer.Accounts.Balance}");
        Console.WriteLine();
    }

    Console.WriteLine();
    
    List<Transaction> transactions = context.Transactions.ToList();

    foreach (var transaction in transactions)
    {
        Console.WriteLine($"transaction id : {transaction.id}\ntransaction account:{transaction.Accounts.id}\ntransaction date : {transaction.TransactionDate}\ntransaction type : {transaction.transactionType} \n" +
            $"transaction amount: {transaction.Amount}");
        Console.WriteLine();
    }
}









Console.WriteLine("enter the customer id");
int id = int.Parse(Console.ReadLine());
id = id + 1000;
Console.WriteLine($"do you want to know the account details of the customer with id {id} (y/n)");
string ch = Console.ReadLine();


methods obj = new methods();
obj.displayCustomer("Cust"+id,ch);











