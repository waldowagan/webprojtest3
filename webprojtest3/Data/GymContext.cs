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

        public DbSet<Student> Students { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<CoursePaper> CoursePaper { get; set; }



    }
}
