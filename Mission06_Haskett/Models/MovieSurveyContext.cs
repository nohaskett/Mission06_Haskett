using Microsoft.EntityFrameworkCore;

namespace Mission06_Haskett.Models
{
    public class MovieSurveyContext : DbContext
    {
        public MovieSurveyContext(DbContextOptions<MovieSurveyContext> options) : base (options)
        {
        }

        public DbSet<MovieSurvey> Movies { get; set; }
    }
}
