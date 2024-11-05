using Farmacity_Backend.DTOs;
using Farmacity_Backend.Entity;
using Farmacity_Backend.Interfaces;

namespace Farmacity_Backend.Services
{
    public class ProductoService
    {
        private readonly IProductoRepository _productoRepository;
        private readonly ICodigoBarraRepository _codigoBarraRepository;

        public ProductoService(IProductoRepository productoRepository, ICodigoBarraRepository codigoBarraRepository)
        {
            _productoRepository = productoRepository;
            _codigoBarraRepository = codigoBarraRepository;
        }

        public async Task<Producto> GetByIdAsync(int id)
        {
            return await _productoRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Producto>> GetAllAsync()
        {
            return await _productoRepository.GetAllAsync();
        }

        public async Task<Producto> AddAsync(Producto producto)
        {
                return await _productoRepository.AddAsync(producto);
        }

        public async Task<bool> UpdateAsync(int id, ProductoUpdateDTO productoUpdate)
        {
            try
            {
                var producto = await _productoRepository.GetByIdAsync(id);

                if (producto == null) return false;

                if (!string.IsNullOrEmpty(productoUpdate.Nombre)) producto.Nombre = productoUpdate.Nombre;

                if (productoUpdate.Precio.HasValue && productoUpdate.Precio.Value >= 0) producto.Precio = productoUpdate.Precio.Value;

                if (productoUpdate.CantidadEnStock.HasValue && productoUpdate.CantidadEnStock.Value >= 0) producto.CantidadEnStock = productoUpdate.CantidadEnStock.Value;

                if (productoUpdate.Activo.HasValue) producto.Activo = productoUpdate.Activo.Value;

                producto.FechaModificacion = DateTime.UtcNow;
                await _productoRepository.UpdateAsync(producto);

                if (productoUpdate.CodigoBarras != null && productoUpdate.CodigoBarras.Any())
                {
                    await _codigoBarraRepository.DeleteByProductIdAsync(id);

                    var nuevosCodigosBarras = productoUpdate.CodigoBarras.Select(c => new CodigoBarra
                    {
                        Codigo = c.Codigo,
                        Activo = c.Activo,
                        FechaAlta = c.FechaAlta ?? DateTime.UtcNow,
                        FechaModificacion = c.FechaAlta.HasValue ? DateTime.UtcNow : (DateTime?)null,
                        ProductoId = id
                    }).ToList();

                    await _codigoBarraRepository.AddRangeAsync(nuevosCodigosBarras);
                }

                return true;
            } catch { return false; }
        }

        public async Task DeleteAsync(int id)
        {
            await _productoRepository.DeleteAsync(id);
        }
    }
}
