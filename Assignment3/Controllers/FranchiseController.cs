using Assignment3.Models;
using Assignment3.Models.DTO.Franchise;
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
    [Route("api/franchises")]
    [ApiController]
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    [ApiConventionType(typeof(DefaultApiConventions))]
    public class FranchiseController : Controller
    {
        private readonly CinemaDbContext _context;
        // Add automapper via DI
        private readonly IMapper _mapper;

        public FranchiseController(CinemaDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        /// <summary>
        /// Gets all franchises.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FranchiseReadDTO>>> GetFranchises()
        {
            return _mapper.Map<List<FranchiseReadDTO>>(await _context.Franchises.ToListAsync());
        }
        /// <summary>
        /// Gets franchise by Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<FranchiseReadDTO>> GetFranchise(int id)
        {
            var franchise = await _context.Franchises.FindAsync(id);
            if(franchise == null)
            {
                return NotFound();
            }
            return _mapper.Map<FranchiseReadDTO>(franchise);
        }
        /// <summary>
        /// Updates Franchise by Id.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="franchise"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFranchise(int id, FranchiseEditDTO franchise)
        {
            if(id != franchise.Id)
            {
                return BadRequest();
            }
            Franchise domainFranchise = _mapper.Map<Franchise>(franchise);
            _context.Entry(domainFranchise).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FranchiseExists(id))
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
        /// Creates a new Franchise.
        /// </summary>
        /// <param name="franchise"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<Franchise>> PostFranchise(Franchise franchise)
        {
            _context.Franchises.Add(franchise);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetFranchise", new { id = franchise.Id }, franchise);
        }

        /// <summary>
        /// Deletes Franchise by Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFranchise(int id)
        {
            var franchise = await _context.Franchises.FindAsync(id);
            if(franchise == null)
            {
                return NotFound();
            }
            _context.Franchises.Remove(franchise);
            await _context.SaveChangesAsync();
            return NoContent();
        }


        /// <summary>
        /// Checks if Franchise exists by Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private bool FranchiseExists(int id)
        {
            return _context.Franchises.Any(e => e.Id == id);
        }
    }
}
