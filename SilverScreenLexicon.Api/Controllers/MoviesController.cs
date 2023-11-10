using MediatR;
using Microsoft.AspNetCore.Mvc;
using SilverScreenLexicon.Application.Queries;
using SilverScreenLexicon.Shared.DTOs;

namespace SilverScreenLexicon.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class MoviesController : ControllerBase
{
    private readonly IMediator _mediator;

    public MoviesController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<MovieItemDto>>> GetMoviesAsync()
    {
        var movies = await _mediator.Send(new GetMoviesQuery());

        return Ok(movies);
    }

    [HttpGet("{movieId:guid}")]
    public async Task<ActionResult<MovieDto>> GetMovieAsync(Guid movieId)
    {
        var movie = await _mediator.Send(new GetMovieQuery(movieId));

        if (movie is null)
            return NotFound();

        return Ok(movie);
    }
}