using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KE.ERP.Domain;
using KE.ERP.Api.Persistence.Extensions;
using KE.ERP.Domain.Touchpoints;
using KE.ERP.Domain.Addresses;

namespace KE.ERP.Api.Persistence
{
    public class ProductDBContext : DbContext
    {
        public ProductDBContext(DbContextOptions<ProductDBContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
        public DbSet<Address> Addresses { get; set; }

        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Domain.Customers.Customer> Customers { get; set; }
        public DbSet<Domain.Products.Product> Products { get; set; }
        public DbSet<Domain.Products.ProductCategory> ProductCategories { get; set; }
        public DbSet<Touchpoint> Touchpoints { get; set; }
        public DbSet<Domain.Users.User> Users { get; set; }
    }
}
