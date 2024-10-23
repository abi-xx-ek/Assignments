using Card.Management.Application.Entity;
using Card.Management.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card.Management.Infrastructure.Data
{
    public class CardManagementContext : DbContext
    {
        public CardManagementContext(DbContextOptions<CardManagementContext> options) : base(options)
        {
        }

        public DbSet<Accounts> Accounts { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Transactions> Transactions { get; set; }
    }
}
