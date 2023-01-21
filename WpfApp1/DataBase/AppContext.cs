using Microsoft.EntityFrameworkCore;
using WpfApp1.model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace WpfApp1.DataBase
{
    public class AppContextDb : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<card> cards { get; set; } = null!;

        public AppContextDb() => Database.EnsureCreated();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=bank.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().Property(x => x.Id);
            modelBuilder.Entity<card>().Property(c => c.ID);
            modelBuilder.Entity<card>().HasOne(u => u.user)
                .WithOne(u => u.Card)
                .HasForeignKey<User>(u => u.CardId);
        }
    }
}
