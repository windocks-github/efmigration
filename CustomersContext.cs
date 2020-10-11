using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkMigrationScript
{
    public class CustomersContext : DbContext
    {

        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Replace this Instance with your container instance that you are developing against
            optionsBuilder.UseSqlServer(@"Server=.\INSTANCE10001"  + ";Database=customers;Trusted_Connection=True;");
        }
    }
}
