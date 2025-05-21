

using System;
using System.IO;
using SmartCity.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace SmartCity.Repository.Context
{
        public class DataBaseContext : DbContext
        {
            public DbSet<TipoProduto> TipoProduto { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                if (!optionsBuilder.IsConfigured)
                {
                    var config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
                    optionsBuilder.UseOracle(config.GetConnectionString("FiapSmartCityConnection"))
                    .LogTo(Console.WriteLine, LogLevel.Information)
                    .EnableSensitiveDataLogging();
        
            }

            }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TipoProduto>()
                .Property(e => e.Comercializado)
                .HasConversion<int>(); // mapeia bool como 0/1
        }


    }
}

