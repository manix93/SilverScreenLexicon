using MediatR;
using Microsoft.EntityFrameworkCore;
using SilverScreenLexicon.Infrastructure;
using SilverScreenLexicon.Shared.DTOs;

namespace SilverScreenLexicon.Application.Queries.Handlers;

public sealed class GetMoviesQueryHandler : IRequestHandler<GetMoviesQuery, IEnumerable<MovieItemDto>>
{
    private readonly SilverScreenLexiconDbContext _dbContext;

    public GetMoviesQueryHandler(SilverScreenLexiconDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<MovieItemDto>> Handle(GetMoviesQuery request, CancellationToken cancellationToken)
    {
        return await _dbContext.Movies
            .AsNoTracking()
            .Select(x => new MovieItemDto(x.Id, x.Name, x.CreatedAt))
            .ToListAsync(cancellationToken);
    }
}