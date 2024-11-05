using Farmacity_Backend.Entity;
using Farmacity_Backend.Interfaces;
using Farmacity_Backend.Utilities;
using Microsoft.EntityFrameworkCore;

namespace Farmacity_Backend.Repositories
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Producto>> GetAllAsync()
        {
            return await _context.Productos.Include(p => p.CodigoBarras).ToListAsync();
        }

        public async Task<Producto> GetByIdAsync(int id)
        {
            var res = await _context.Productos.Include(p => p.CodigoBarras).FirstOrDefaultAsync(p => p.Id == id);
            if (res == null)
            {
                throw new KeyNotFoundException($"Producto con Id {id} no encontrado.");
            }
            else { return res; }
        }

        public async Task<Producto> AddAsync(Producto producto)
        {
            await _context.Productos.AddAsync(producto);
            await _context.SaveChangesAsync();

            return producto;
        }

        public async Task UpdateAsync(Producto producto)
        {
            _context.Productos.Update(producto);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var producto = await _context.Productos.FindAsync(id);
            if (producto != null)
            {
                _context.Productos.Remove(producto);
                await _context.SaveChangesAsync();
            }
        }
    }
}