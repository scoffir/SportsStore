using Microsoft.EntityFrameworkCore;
using SportsStore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportsStore
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var connection = "Server=.;Database= 07_Ex_LINQ;Integrated security= true;";
            optionsBuilder.UseSqlServer(connection);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
        }
    }
}
