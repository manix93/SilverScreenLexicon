using MediatR;
using SilverScreenLexicon.Shared.DTOs;

namespace SilverScreenLexicon.Application.Queries;

public record GetMovieQuery(Guid MovieId) : IRequest<MovieDto?>;