using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DateAccess.Concrete.EntityFramework
{
    //context : DB tabloları ile classlarını bağlamak
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Northwind;Trusted_Connection=true");

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
