using MediatR;
using Microsoft.EntityFrameworkCore;
using SilverScreenLexicon.Infrastructure;
using SilverScreenLexicon.Shared.DTOs;

namespace SilverScreenLexicon.Application.Queries.Handlers;

public sealed class GetMovieQueryHandler : IRequestHandler<GetMovieQuery, MovieDto?>
{
    private readonly SilverScreenLexiconDbContext _dbContext;

    public GetMovieQueryHandler(SilverScreenLexiconDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<MovieDto?> Handle(GetMovieQuery request, CancellationToken cancellationToken)
    {
        var movie = await _dbContext.Movies
            .AsNoTracking()
            .SingleOrDefaultAsync(x => x.Id == request.MovieId, cancellationToken);

        return movie?.AsDto();
    }
}