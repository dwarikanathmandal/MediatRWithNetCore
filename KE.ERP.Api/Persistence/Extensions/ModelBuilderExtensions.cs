using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KE.ERP.Domain;

namespace KE.ERP.Api.Persistence.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Touchpoint>().HasData(
                new Touchpoint
                {
                    TouchpointId = 1,
                    TouchpointName = "Rental",                   
                },
                new Touchpoint 
                {
                     TouchpointId = 2,
                    TouchpointName = "Sales", 
                },
                new Touchpoint 
                {
                     TouchpointId = 3,
                    TouchpointName = "Service", 
                }
            );           
        }
    }
}