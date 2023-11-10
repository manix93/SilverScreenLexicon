using MediatR;
using SilverScreenLexicon.Shared.DTOs;

namespace SilverScreenLexicon.Application.Queries;

public record GetMoviesQuery : IRequest<IEnumerable<MovieItemDto>>;