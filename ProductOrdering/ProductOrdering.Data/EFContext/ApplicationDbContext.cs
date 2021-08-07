using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProductOrdering.Core.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductOrdering.Data.EFContext
{
    public class ApplicationDbContext : IdentityDbContext<User, Role, long>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base( options)
        {

        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Merchant> Merchants { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        //public DbSet<Supplier> Suppliers { get; set; }
        //public DbSet<Territory> Territories { get; set; }
        //public DbSet<Vendor> Vendor { get; set; }
        //public DbSet<Customer> Customers { get; set; }
        //public DbSet<CustomerDetail> CustomersDetail { get; set; }
        //public DbSet<CustomerSalesOrder> CustomersSalesOrder { get; set; }     
        //public DbSet<CustomerVendor> CustomersVendor { get; set; }  
        //public DbSet<CustomerVendorDetail> CustomersVendorDetail { get; set; }
        //public DbSet<CustomerView> CustomersView { get; set; }
        //public DbSet<CustomerViewDetail> CustomersViewDetail { get; set; }
        //public DbSet<ProductOrder> ProductOrders { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
