using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{

    public class CabinsController : BaseApiController
    {
        private readonly loscielosDbContext _context;
        public CabinsController(loscielosDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<List<Cabin>> ListCabins()
        {
            return await _context.Cabins.ToListAsync();
        }

        [HttpGet ("{id}")]
        public async Task<Cabin> GetCabin(Guid id)
        {
             return await _context.Cabins.FindAsync(id);
        }
    }
}