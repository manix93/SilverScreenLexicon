using MediatR;
using SilverScreenLexicon.Core.Entities;
using SilverScreenLexicon.Infrastructure;
using SilverScreenLexicon.Shared.DTOs;

namespace SilverScreenLexicon.Application.Commands.Handlers;

public class CreateMovieCommandHandler : IRequestHandler<CreateMovieCommand, MovieDto>
{
    private readonly SilverScreenLexiconDbContext _dbContext;

    public CreateMovieCommandHandler(SilverScreenLexiconDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<MovieDto> Handle(CreateMovieCommand request, CancellationToken cancellationToken)
    {
        var movie = new Movie(request.Name);
        _dbContext.Movies.Add(movie);
        await _dbContext.SaveChangesAsync(cancellationToken);

        return movie.AsDto();
    }
}