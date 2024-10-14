using InterviewPreparation.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace InterviewPreparation.Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public required DbSet<Algorithm> Algorithms { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
