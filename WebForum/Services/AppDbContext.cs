using HW3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HW3.Services
{
    public class AppDbContext : DbContext
    {
        private static readonly string ConnectionString;

        static AppDbContext()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            ConnectionString = config.GetConnectionString("Default");
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Topic>()
                .HasOne<Forum>(t => t.forum)
                .WithMany(f => f.topic)
                .HasForeignKey(t => t.ForumId);

            modelBuilder.Entity<Reply>()
               .HasOne<Topic>(t => t.topic)
               .WithMany(f => f.reply)
               .HasForeignKey(t => t.TopicId);
        }
        


        public DbSet<Forum> Forums { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Reply> Replies { get; set; }


    }
}
