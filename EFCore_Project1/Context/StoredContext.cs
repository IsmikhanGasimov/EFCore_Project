using EFCore_Project1.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_Project1.Context
{
    public class StoredContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=ASUS\SQLEXPRESS;Database=BookSystemEF;Trusted_Connection=Yes;TrustServerCertificate=True;");
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Writer> writers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasKey(x=>x.Id);
            modelBuilder.Entity<Address>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<Customer>()
                .HasKey(x => x.Orders);
            modelBuilder.Entity<Customer>()
                .HasMany(x => x.Orders)
                .WithOne(x => x.Customer)
                .HasForeignKey(x=>x.CId);

            modelBuilder.Entity<Genre>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<Order>()
                .HasKey(x => x.Id);
            modelBuilder.Entity<Writer>()
                .HasKey(x => x.Id);
            
        }


    }
}
