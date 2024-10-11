using CardManagement;
using CardManagement.Model.Models;
using CardManagment.Model.Data;
using Microsoft.EntityFrameworkCore;

using (CardManagmentContext context = new CardManagmentContext())
{
  
        int accId= context.Accounts.Count();

        int tranId = context.Transactions.Count();

        int custId = context.Transactions.Count();
  

    List<Account> account = new List<Account>()
        {

        new Account(accId+1)
        {
            AccountNumber = "100210",
            AccountType = "savings",
            Balance = 10000
        },

        

    new Account(accId+2)
        {
            AccountNumber = "798745",
            AccountType = "savings",
            Balance = 24500
        }
        };
    foreach (var item in  account)
    {
        context.Accounts.Add(item);
        context.SaveChanges();

    }



    


    List<Transaction> transactions = new List<Transaction>()
        {
        new Transaction(tranId+1)
        {

            TransactionDate = DateTime.Now,
            transactionType = Transaction.TransactionType.Transfer,
            Amount = 1500,
            Description = "transfering amt",
            Accounts = account[0]
        },
        new Transaction(tranId+2)
        {

            TransactionDate = new DateTime(2023, 10, 5),
            transactionType = Transaction.TransactionType.Deposit,
            Amount = 2000,
            Description = "depositing",
            Accounts = account[1]

        }

    };

    foreach (var item in transactions)
    {
        context.Transactions.Add(item);
        context.SaveChanges();

    }


    List<Customer> c = new List<Customer>()
        {
            new Customer(custId+1)
            {

                CustomerName = "abhi",
                CustomerAddress = "trivandtum",
                Email = "abhishek@gmail.com",
                PhoneNumber = "7356735678",
                Accounts = account[0]
            },
            new Customer(custId+2)
            {

                CustomerName = "hari",
                CustomerAddress = "kollam",
                Email = "hari@gmail.com",
                PhoneNumber = "7845125637",
                Accounts = account[1]
            }
        };


    foreach (var item in c)
    {
        context.Customers.Add(item);
        context.SaveChanges();

    }



    List<Customer> customers = context.Customers.ToList();
    foreach (var customer in customers)
    {
        Console.WriteLine($"customer id : {customer.id}\ncustomer name : {customer.CustomerName}\ncustomer email : {customer.Email}");
        Console.WriteLine();
    }

    Console.WriteLine();


    List<Customer> cust_acc = context.Customers.Include(x => x.Accounts).ToList();

    foreach (var customer in cust_acc)
    {
        Console.WriteLine($"acoount id : {customer.Accounts.id}\naccount number : {customer.Accounts.AccountNumber}\naccount type : {customer.Accounts.AccountType} \nbalance : {customer.Accounts.Balance}");
        Console.WriteLine();
    }

    Console.WriteLine();

    List<Transaction> t = context.Transactions.Include(x => x.Accounts).ToList();

    foreach (var transaction in t)
    {
        Console.WriteLine($"transaction id : {transaction.id}\ntransaction account:{transaction.Accounts.id}\ntransaction date : {transaction.TransactionDate}\ntransaction type : {transaction.transactionType} \n" +
            $"transaction amount: {transaction.Amount}");
        Console.WriteLine();
    }
    Account findobj = context.Accounts.FirstOrDefault(x => x.id == "Acc1001");

    List<Transaction> transactionobj = new List<Transaction>()
    {
        new Transaction(tranId + 3)
        {
            TransactionDate = DateTime.Now,
            transactionType = Transaction.TransactionType.Transfer,
            Amount = 1500,
            Description = "transfering amt",
            Accounts = findobj
        } };
    methods obj = new methods();

    obj.AmountChange(findobj, transactionobj);
    context.Transactions.AddRange(transactionobj);
    context.SaveChanges();





    Console.WriteLine("enter the customer id");
    int id = int.Parse(Console.ReadLine());
    id = id + 1000;
    Console.WriteLine($"do you want to know the account details of the customer with id {id} (y/n)");
    string ch = Console.ReadLine();
    obj.displayCustomer("Cust" + id, ch);















