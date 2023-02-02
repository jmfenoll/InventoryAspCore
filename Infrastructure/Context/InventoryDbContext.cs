using System;
using System.Collections.Generic;
using Inventory.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Inventory.Infrastructure.EFSqlRepository.Context;

public partial class InventoryDbContext : DbContext
{
    public InventoryDbContext(DbContextOptions options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Product>()
            .Property(p => p.Quantity)
            .HasColumnType("decimal(16,2)");

        modelBuilder.Entity<Product>().HasKey(x => x.Id);

        modelBuilder.Entity<Product>().ToTable("Products");


    }

    public virtual DbSet<Product> Products { get; set; }
}
