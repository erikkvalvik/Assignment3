using Assignment3.Models;
using Assignment3.Models.DTO.Movie;
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
    [Route("api/MovieFranchise")]
    [ApiController]
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    [ApiConventionType(typeof(DefaultApiConventions))]
    public class MovieFranchiseController : Controller
    {
        private readonly CinemaDbContext _context;
        // Add automapper via DI
        private readonly IMapper _mapper;

        public MovieFranchiseController(CinemaDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        /// <summary>
        /// Gets all movies in a franchise by franchiseId.
        /// </summary>
        /// <param name="franchiseId"></param>
        /// <returns></returns>
        [HttpGet("{FranchiseId}")]
        public async Task<ActionResult<IEnumerable<MovieReadDTO>>> GetMoviesByFranchise(int franchiseId)
        {

            var movies = await _context.Movies.Where(m => m.FranchiseId.ToString().Contains(franchiseId.ToString())).ToListAsync();
            if (movies == null)
            {
                return NotFound();
            }
            return _mapper.Map<List<MovieReadDTO>>(movies);


        }
    }
}
