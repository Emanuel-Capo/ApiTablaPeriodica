using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortfolioApps.DTOs;

namespace PortfolioApps.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ElementoController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public ElementoController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<ElementoDTO>>> Get()
        {
            var elementos = await _context.Elementos
                .Include(e => e.Grupo)
                .Include(e => e.Reacciones)
                .ToListAsync();
            return _mapper.Map<List<ElementoDTO>>(elementos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ElementoDTO>> Get(int id)
        {
            try
            {
                var elemento = await _context.Elementos
                    .Where(e=>e.Id== id)
                    .Include(e => e.Grupo)
                    .Include(e => e.Reacciones)
                    .FirstOrDefaultAsync();
                if (elemento == null) return NotFound();
                return _mapper.Map<ElementoDTO>(elemento);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
