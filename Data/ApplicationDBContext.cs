using dotNetCoreEntityFramework.Domain;
using Microsoft.EntityFrameworkCore;

namespace dotNetCoreEntityFramework.Data
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) :base (options)
        {

            
        }


        public DbSet<Product> Products {get ; set;}
        public DbSet<Category> Categories {get ; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*modelBuilder.Entity<Product>().ToTable("Prod");
            modelBuilder.Entity<Product>().Property(p => p.Name).HasMaxLength(100);
            modelBuilder.Entity<Category>().ToTable("Cat");
            modelBuilder.Entity<Category>().Property(p => p.Name).HasMaxLength(50);*/

            
        }


    }
}