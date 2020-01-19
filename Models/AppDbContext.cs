using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_WebApp.Models
{
    //Manage all data access
    public class AppDbContext :DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        /// <summary>
        /// The Dbcontext options will be the injected DBcontext class
        /// in DI container of the applicaton aka configureservices()
        /// this class will read connection string from DI container
        /// </summary>
        /// 
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
