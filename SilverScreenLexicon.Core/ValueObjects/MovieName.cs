using SilverScreenLexicon.Core.Exceptions;

namespace SilverScreenLexicon.Core.ValueObjects;

public sealed record MovieName
{
    public string Value { get; }

    public MovieName(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new InvalidMovieNameException();

        Value = value;
    }

    public static implicit operator string(MovieName movieName) => movieName.Value;

    public static implicit operator MovieName(string value) => new(value);
}