using SilverScreenLexicon.Core.ValueObjects;

namespace SilverScreenLexicon.Core.Entities;

public class Movie
{
    public MovieId Id { get; private set; }
    
    public MovieName Name { get; private set; }
    
    public DateTimeOffset CreatedAt { get; private set; }

    public Movie(MovieName name)
    {
        Id = Guid.NewGuid();
        Name = name;
        CreatedAt = DateTimeOffset.UtcNow;
    }
}