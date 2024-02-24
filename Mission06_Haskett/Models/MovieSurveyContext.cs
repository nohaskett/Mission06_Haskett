using Microsoft.EntityFrameworkCore;

namespace Mission06_Haskett.Models
{
    public class MovieSurveyContext : DbContext
    {
        public MovieSurveyContext(DbContextOptions<MovieSurveyContext> options) : base (options)
        {
        }

        public DbSet<Movies> Movies { get; set; }
        public DbSet<Category> Categories {  get; set; } // This is the name that will match the database
        
        protected override void OnModelCreating(ModelBuilder modelBuilder) // Seed Data
        {
            modelBuilder.Entity<Category>().HasData(

                new Category { CategoryId = 1, CategoryName = "Miscellaneous" },
                new Category { CategoryId = 2, CategoryName = "Drama" },
                new Category { CategoryId = 3, CategoryName = "Television" },
                new Category { CategoryId = 4, CategoryName = "Horror/Suspense" },
                new Category { CategoryId = 5, CategoryName = "Comedy" },
                new Category { CategoryId = 6, CategoryName = "Family" },
                new Category { CategoryId = 7, CategoryName = "Action/Adventure" },
                new Category { CategoryId = 8, CategoryName = "VHS" }
                );
        }
    }
}
