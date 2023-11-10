using Microsoft.EntityFrameworkCore;
using SilverScreenLexicon.Core.Entities;

namespace SilverScreenLexicon.Infrastructure;

public sealed class SilverScreenLexiconDbContext : DbContext
{
    public DbSet<Movie> Movies { get; set; }
    
    public SilverScreenLexiconDbContext(DbContextOptions<SilverScreenLexiconDbContext> options) : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
    }
}