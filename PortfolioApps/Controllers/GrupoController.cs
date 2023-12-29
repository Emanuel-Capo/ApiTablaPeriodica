using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortfolioApps.DTOs;
using PortfolioApps.Entidades;

namespace PortfolioApps.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GrupoController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public GrupoController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<GenericDTO>>> Get()
        {
            var grupos = await _context.Grupos.ToListAsync();
            return _mapper.Map<List<GenericDTO>>(grupos);
        }
    }
}
