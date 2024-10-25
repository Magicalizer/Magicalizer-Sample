// Copyright © 2024 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using App.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace App;

public class AppDbContext : DbContext
{
  DbSet<Category> Categories { get; set; }
  DbSet<Product> Products { get; set; }
  DbSet<Photo> Photos { get; set; }

  public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
  {
  }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<Category>(etb =>
      {
        etb.HasKey(e => e.Id);
        etb.Property(e => e.Id);
        etb.ToTable("Categories");
      }
    );

    modelBuilder.Entity<Product>(etb =>
      {
        etb.HasKey(e => e.Id);
        etb.Property(e => e.Id);
        etb.ToTable("Products");
      }
    );

    modelBuilder.Entity<Photo>(etb =>
      {
        etb.HasKey(e => e.Id);
        etb.ToTable("Photos");
      }
    );

    base.OnModelCreating(modelBuilder);
  }
}