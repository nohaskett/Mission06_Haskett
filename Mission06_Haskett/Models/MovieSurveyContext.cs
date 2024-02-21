using Microsoft.EntityFrameworkCore;

namespace Mission06_Haskett.Models
{
    public class MovieSurveyContext : DbContext
    {
        public MovieSurveyContext(DbContextOptions<MovieSurveyContext> options) : base (options)
        {
        }

        public DbSet<MovieSurvey> Movies { get; set; }
        public DbSet<CategoryList> Categories {  get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder) // Seed Data
        {
            modelBuilder.Entity<CategoryList>().HasData(

                new CategoryList { CategoryId = 1, Category = "Miscellaneous" },
                new CategoryList { CategoryId = 2, Category = "Drama" },
                new CategoryList { CategoryId = 3, Category = "Television" },
                new CategoryList { CategoryId = 4, Category = "Horror/Suspense" },
                new CategoryList { CategoryId = 5, Category = "Comedy" },
                new CategoryList { CategoryId = 6, Category = "Family" },
                new CategoryList { CategoryId = 7, Category = "Action/Adventure" },
                new CategoryList { CategoryId = 8, Category = "VHS" }
                );
        }
    }
}
