using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SilverScreenLexicon.Core.Entities;
using SilverScreenLexicon.Core.ValueObjects;

namespace SilverScreenLexicon.Infrastructure.Configurations;

public sealed class MovieConfiguration : IEntityTypeConfiguration<Movie>
{
    public void Configure(EntityTypeBuilder<Movie> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
            .HasConversion(x => x.Value, x => new MovieId(x));
        builder.Property(x => x.Name)
            .HasConversion(x => x.Value, x => new MovieName(x))
            .IsRequired();
        builder.Property(x => x.CreatedAt)
            .IsRequired();
    }
}