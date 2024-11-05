using AutoMapper;
using Farmacity_Backend.DTOs;
using Farmacity_Backend.Entity;
using Farmacity_Backend.Services;
using Microsoft.AspNetCore.Mvc;
namespace Farmacity_Backend.Controllers
{
    [ApiController]
    [Route("api/productos")]
    public class ProductosController : ControllerBase
    {
        private readonly ProductoService _productoService;
        private readonly IMapper _mapper;

        public ProductosController(ProductoService productoService, IMapper mapper)
        {
            _productoService = productoService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Producto>>> Get()
        {
            return Ok(await _productoService.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Producto>> Get(int id)
        {
            return Ok(await _productoService.GetByIdAsync(id));
        }

        [HttpPost]
        public async Task<ActionResult> Post(ProductoAddDTO productoAdd)
        {
            if (productoAdd == null) return BadRequest("El producto a agregar no puede ser nulo.");
                
            var producto = _mapper.Map<Producto>(productoAdd);

            var res = await _productoService.AddAsync(producto);

            if (res) return Ok();
            return StatusCode(500, "Error al crear producto.");
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, ProductoUpdateDTO productoUpdate)
        {
            if (id != productoUpdate.Id) return BadRequest();

            var res = await _productoService.UpdateAsync(id, productoUpdate);

            if (res) return Ok();
            return StatusCode(500, "Error al crear producto.");
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _productoService.DeleteAsync(id);
            return Ok();
        }
    }
}
