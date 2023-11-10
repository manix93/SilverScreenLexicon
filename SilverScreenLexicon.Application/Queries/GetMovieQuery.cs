using MediatR;
using SilverScreenLexicon.Core.ValueObjects;
using SilverScreenLexicon.Shared.DTOs;

namespace SilverScreenLexicon.Application.Queries;

public record GetMovieQuery(MovieId MovieId) : IRequest<MovieDto?>;