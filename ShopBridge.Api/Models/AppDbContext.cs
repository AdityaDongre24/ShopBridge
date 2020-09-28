using Microsoft.EntityFrameworkCore;
using ShopBridgeModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopBridge.Api.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base(options)
        { }

        public DbSet<Item> Items { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seed Data
            modelBuilder.Entity<Item>().HasData(new Item() { Id = 1, Name = "item1", Description = "Des1", Price = 10, ImageSource = "images/airplane.png" }); ;
        }

    }
}
