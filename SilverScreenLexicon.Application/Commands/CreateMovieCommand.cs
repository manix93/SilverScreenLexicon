using MediatR;
using SilverScreenLexicon.Shared.DTOs;

namespace SilverScreenLexicon.Application.Commands;

public sealed record CreateMovieCommand(string Name) : IRequest<MovieDto>;