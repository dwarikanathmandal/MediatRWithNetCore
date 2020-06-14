using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KE.ERP.Domain;
using KE.ERP.Api.Persistence.Extensions;

namespace KE.ERP.Api.Persistence
{
    public class ProductDBContext : DbContext
    {
        public ProductDBContext(DbContextOptions<ProductDBContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }

        public DbSet<Touchpoint> Touchpoints { get; set; }

    }
}
