using MediatR;
using SilverScreenLexicon.Core.ValueObjects;
using SilverScreenLexicon.Shared.DTOs;

namespace SilverScreenLexicon.Application.Queries;

public sealed record GetMovieQuery(MovieId MovieId) : IRequest<MovieDto?>;