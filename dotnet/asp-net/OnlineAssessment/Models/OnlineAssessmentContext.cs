using Microsoft.EntityFrameworkCore;
namespace OnlineAssessment.Models;

public class OnlineAssessmentContext : DbContext
{
    public OnlineAssessmentContext(DbContextOptions options)
        : base (options)
    {

    }

    public DbSet<Question> Questions { get; set; }
}