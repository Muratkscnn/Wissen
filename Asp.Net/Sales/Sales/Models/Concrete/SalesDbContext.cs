using Microsoft.EntityFrameworkCore;
using Sales.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sales.Models.Concrete
{
    public class SalesDbContext : DbContext
    {
        public SalesDbContext()
        {

        }
        public SalesDbContext(DbContextOptions<SalesDbContext> options) : base (options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseSqlServer("Server=DESKTOP-8M7D7GE\\SQLEXPRESS;Database=SalesDbSabah;Trusted_Connection=true;");
           optionsBuilder.UseSqlServer("Server=MK\\SQLEXPRESS;Database=SalesDbSabah;Trusted_Connection=true;");

        }
    }
}
