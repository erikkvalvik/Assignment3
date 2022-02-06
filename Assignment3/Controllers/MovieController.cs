using Assignment3.Models;
using Assignment3.Models.DTO.Movie;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace Assignment3.Controllers
{
    [Route("api/movies")]
    [ApiController]
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    [ApiConventionType(typeof(DefaultApiConventions))]

    public class MovieController : Controller
    {
        private readonly CinemaDbContext _context;
        // Add automapper via DI
        private readonly IMapper _mapper;

        public MovieController(CinemaDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        /// <summary>
        /// Gets all the movies in the database.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MovieReadDTO>>> GetMovies()
        {
            return _mapper.Map<List<MovieReadDTO>>(await _context.Movies.ToListAsync());
        }
        

        /// <summary>
        /// Gets a specific movie by its Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<MovieReadDTO>> GetMovie(int id)
        {
            var movie = await _context.Movies.FindAsync(id);
            if(movie == null)
            {
                return NotFound();
            }
            return _mapper.Map<MovieReadDTO>(movie);
        }

        /// <summary>
        /// Updates a movie.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="movie"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMovie(int id, MovieEditDTO movie)
        {
            if(id != movie.Id)
            {
                return BadRequest();
            }
            Movie domainMovie = _mapper.Map<Movie>(movie);
            _context.Entry(domainMovie).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MovieExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return NoContent();
        }
        /// <summary>
        /// Adds a new movie to the database.
        /// </summary>
        /// <param name="movie"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<Movie>> PostMovie(Movie movie)
        {
            _context.Movies.Add(movie);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetMovie", new { id = movie.Id }, movie);
        }
        /// <summary>
        /// Deletes a movie by Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMovie(int id)
        {
            var movie = await _context.Movies.FindAsync(id);
            if(movie == null)
            {
                return NotFound();
            }
            _context.Movies.Remove(movie);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        /// <summary>
        /// Checks if a movie exists by Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>True if any matches in DB, False if not.</returns>
        private bool MovieExists(int id)
        {
            return _context.Movies.Any(e => e.Id == id);
        }

    }
}
