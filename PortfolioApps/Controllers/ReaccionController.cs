using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortfolioApps.DTOs;

namespace PortfolioApps.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReaccionController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public ReaccionController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<GenericDTO>>> Get()
        {
            var reacciones = await _context.Reacciones.ToListAsync();
            return _mapper.Map<List<GenericDTO>>(reacciones);
        }
    }
}
