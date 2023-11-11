using MediatR;
using SilverScreenLexicon.Shared.DTOs;

namespace SilverScreenLexicon.Application.Queries;

public sealed record GetMoviesQuery : IRequest<IEnumerable<MovieItemDto>>;