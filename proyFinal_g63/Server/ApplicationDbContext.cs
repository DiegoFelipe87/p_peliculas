using Microsoft.EntityFrameworkCore;
using proyFinal_g63.Shared.Model;

namespace proyFinal_g63.Server  
{
    public class ApplicationDbContext:DbContext
    {
            public DbSet<Movie> Movies{get;set;}
            public DbSet<Category> Categories{get;set;}
            public DbSet<CategoryMovie> CategoriesMovie{get;set;}

            public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options){

            }

            protected override void OnModelCreating(ModelBuilder modelBuilder){
                modelBuilder.Entity<CategoryMovie>().HasKey( x=>new {x.CategoryId, x.MovieId} );
                base.OnModelCreating(modelBuilder);
            }
    }
}