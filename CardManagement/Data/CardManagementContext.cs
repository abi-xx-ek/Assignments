using CardManagement.Model.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardManagment.Model.Data
{
    public class CardManagmentContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        public void savechanges()
        {
            throw new NotImplementedException();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server=localhost,1430;Database=CardManagement;User Id=sa;Password=abhi@123;TrustServerCertificate=true");
        }

    }
}
