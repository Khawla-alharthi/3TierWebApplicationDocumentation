using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using _3TierWebApplication.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace _3TierWebApplication.DAL.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        // Define DbSet properties for your entities here
        public DbSet<Category> categories { get; set; }
        public DbSet<Product> products { get; set; }

    }
}
