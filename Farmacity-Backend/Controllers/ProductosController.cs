using AutoMapper;
using Farmacity_Backend.DTOs;
using Farmacity_Backend.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Farmacity_Backend.Controllers
{
    [ApiController]
    [Route("api/productos")]
    public class ProductosController: ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public ProductosController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Producto>>> Get()
        {
            return await _context.Productos.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult> Post(ProductoAddDTO productoAdd)
        {
            var producto = _mapper.Map<Producto>(productoAdd);
            _context.Add(producto);
            await _context.SaveChangesAsync();
            return Ok();
        }

    }
}
