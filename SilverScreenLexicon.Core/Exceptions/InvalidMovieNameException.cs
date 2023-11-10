namespace SilverScreenLexicon.Core.Exceptions;

public sealed class InvalidMovieNameException : BaseException
{
    public InvalidMovieNameException() : base("Movie name is invalid.")
    {
    }
}