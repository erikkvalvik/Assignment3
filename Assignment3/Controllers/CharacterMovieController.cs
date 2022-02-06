using Assignment3.Models;
using Assignment3.Models.DTO.Character;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace Assignment3.Controllers
{
    [Route("api/CharacterMovie")]
    [ApiController]
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    [ApiConventionType(typeof(DefaultApiConventions))]
    public class CharacterMovieController : Controller
    {
        private readonly CinemaDbContext _context;
        // Add automapper via DI
        private readonly IMapper _mapper;

        public CharacterMovieController(CinemaDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        /// <summary>
        /// Returns all character in a movie with movieId.
        /// </summary>
        /// <param name="movieId"></param>
        /// <returns></returns>
        [HttpGet("{MovieId}")]
        public async Task<ActionResult<IEnumerable<CharacterReadDTO>>> GetCharactersByMovie(int movieId)
        {
            var characters = await _context.CharacterMovies.Where(c => c.MovieId.ToString().Contains(movieId.ToString())).ToListAsync();
            return _mapper.Map<List<CharacterReadDTO>>(characters);
        }
        
    }
}
