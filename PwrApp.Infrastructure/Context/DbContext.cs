using Microsoft.EntityFrameworkCore;
using PwrApp.Infrastructure.Entities;

namespace PwrApp.Infrastructure.Context;

public class PwrAppContext : DbContext
{
    public DbSet<CompetitorDB> Competitors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=database.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CompetitorDB>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
            entity.Property(e => e.Age).IsRequired();
            entity.Property(e => e.BodyWeight).IsRequired();
        });
    }
}
