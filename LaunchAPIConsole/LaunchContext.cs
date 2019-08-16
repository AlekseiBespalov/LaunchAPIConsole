using LaunchAPIConsole.ModelsDB;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaunchAPIConsole
{
    class LaunchContext : DbContext
    {
        public DbSet<Launch> Launches { get; set; }
        public DbSet<Agency> Agencies { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = GE73RAIDER; Initial Catalog = InstituteDB; Integrated Security = True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>()
                .HasMany(c => c.Agencies)
                .WithOne(e => e.Country);
            modelBuilder.Entity<Country>()
                .HasMany(c => c.Launches)
                .WithOne(e => e.Country);
            modelBuilder.Entity<Agency>()
                .HasMany(l => l.Launches)
                .WithOne(a => a.Agency);
        }
    }
}
