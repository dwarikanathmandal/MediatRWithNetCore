﻿// <auto-generated />
using KE.ERP.Api.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KE.ERP.Api.Migrations
{
    [DbContext(typeof(ProductDBContext))]
    [Migration("20200614125432_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KE.ERP.Domain.Touchpoint", b =>
                {
                    b.Property<int>("TouchpointId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TouchpointName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TouchpointId");

                    b.ToTable("Touchpoints");

                    b.HasData(
                        new
                        {
                            TouchpointId = 1,
                            TouchpointName = "Rental"
                        },
                        new
                        {
                            TouchpointId = 2,
                            TouchpointName = "Sales"
                        },
                        new
                        {
                            TouchpointId = 3,
                            TouchpointName = "Service"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}