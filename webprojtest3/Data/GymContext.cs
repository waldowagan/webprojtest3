using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webprojtest3.Models;
using Microsoft.EntityFrameworkCore;

namespace webprojtest3.Data
{
    public class GymContext : DbContext
    {
        public GymContext(DbContextOptions<GymContext> options) : base(options)
        {
        }
        public DbSet<User> User { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<CoursePaper> CoursePaper { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<Staff>().ToTable("Staff");
            modelBuilder.Entity<Client>().ToTable("Client");
            modelBuilder.Entity<CoursePaper>().ToTable("CoursePaper");

        }

    }
}
