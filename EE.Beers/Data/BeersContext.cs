using EE.Beers.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EE.Beers.Data
{
    public class BeersContext : DbContext
    {
        public BeersContext(DbContextOptions<BeersContext> options) : base(options) { }

        public DbSet<Beer> Beers { get; set; }
        public DbSet<Flavor> Flavors { get; set; }
        public DbSet<Brouwerij> Brouwerijen{get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder
                .Entity<BeerFlavor>()
                .HasKey(bfl => new { bfl.BeerId, bfl.FlavorId });
            
            modelBuilder
                .Entity<Beer>()
                .HasMany(b => b.Flavors)
                .WithOne(bfl => bfl.Beer);
           
            modelBuilder
                .Entity<Flavor>()
                .HasMany(f => f.BeersWithFlavor)
                .WithOne(bfl => bfl.Flavor);
       
            base.OnModelCreating(modelBuilder);
        }
    }
}