using SilverScreenLexicon.Core.Entities;
using SilverScreenLexicon.Shared.DTOs;

namespace SilverScreenLexicon.Application;

public static class Mappings
{
    public static MovieDto AsDto(this Movie movie) => new(movie.Id, movie.Name, movie.CreatedAt);
}