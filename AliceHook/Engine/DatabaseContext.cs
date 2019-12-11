using System;
using AliceHook.Models;
using Microsoft.EntityFrameworkCore;

namespace AliceHook.Engine
{
    public class DatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            const string database = "alicehook";
            var host = "localhost";
            var user = "root";
            var password = "0898";
            
            optionsBuilder.UseMySql(
                $@"server = {host};"
                + $"Database={database};"
                + $"user id={user};"
                + $"Password={password};"
            );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}