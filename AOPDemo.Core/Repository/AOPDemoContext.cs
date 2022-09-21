using AOPDemo.Model.Customer;
using AOPDemo.Model.Product;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOPDemo.Core.Repository
{
    public class AOPDemoContext : DbContext
    {
        //public AOPDemoContext(DbContextOptions options) : base(options)
        //{

        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=192.168.10.12;Database=HAltinok_Test;User Id=sa;Password=Ledbim99;");
        }



        public DbSet<Model.Product.Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
