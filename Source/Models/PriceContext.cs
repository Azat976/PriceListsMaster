using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace WebApp.Models
{
    public class PriceContext : DbContext
    {
        public DbSet<Price> Prices { get; set; }
        public DbSet<PriceList> PriceLists { get; set; }


        public PriceContext() : base("DefaultConnection")
        { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PriceList>().HasMany(c => c.Prices)
                .WithMany(s => s.PriceLists)
                .Map(t => t.MapLeftKey("PriceListId")
                .MapRightKey("PriceId")
                .ToTable("PricePriceList"));
        }

    }
}