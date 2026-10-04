using Microsoft.EntityFrameworkCore;
namespace JourneyTracker.Web.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<StudyLog> StudyLogs { get; set; }
    }
}
