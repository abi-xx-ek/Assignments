using Card.Management.Application.Entity;
using Card.Management.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Card.Management.Infrastructure.Data
{
    public class TransactionContext:DbContext
    {
        public TransactionContext(DbContextOptions<TransactionContext> options) : base(options)
        {

        }

        public DbSet<Transactions> Trasnsactions { get; set; }
    }
}
