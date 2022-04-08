using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TPH.Models;

namespace TPH
{
    internal class ApplicationContext: DbContext
    {
        public DbSet<User> users { get; set; } = null!;
        public DbSet<Manager> managers { get; set; } = null!;
        public DbSet<Employee> employees{ get; set; } = null!;

        public ApplicationContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("DataSource=People.db");
        }
    }
}
