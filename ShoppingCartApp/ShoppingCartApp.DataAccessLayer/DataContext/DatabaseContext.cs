using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ShoppingCartApp.DataAccessLayer.Models;

namespace ShoppingCartApp.DataAccessLayer.DataContext
{
    public class DatabaseContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var settings = new AppConfiguration();
            optionsBuilder.UseSqlServer(settings.sqlConnectionString);
            base.OnConfiguring(optionsBuilder);
        }

    }
}
