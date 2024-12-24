using MatchMaker.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMaker.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Idea> Ideas { get; set; }

        // קונפיגורציה של ה-DbContext
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Idea>()
                .HasOne(i => i.Guy)
                .WithMany()
                .HasForeignKey(i => i.GuyId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Idea>()
                .HasOne(i => i.Girl)
                .WithMany()
                .HasForeignKey(i => i.GirlId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=MatchMakerDb;Trusted_Connection=True;");
        }
    }
}
