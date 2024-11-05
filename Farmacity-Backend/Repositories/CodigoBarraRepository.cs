using Farmacity_Backend.Utilities;
using Farmacity_Backend.Entity;
using Farmacity_Backend.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Farmacity_Backend.Repositories
{
    public class CodigoBarraRepository : ICodigoBarraRepository
    {
        private readonly ApplicationDbContext _context;

        public CodigoBarraRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Boolean> AddRangeAsync(IEnumerable<CodigoBarra> codigoBarras)
        {
            try
            {
                await _context.CodigoBarras.AddRangeAsync(codigoBarras);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task DeleteByProductIdAsync(int productId)
        {
            var codigoBarras = await _context.CodigoBarras.Where(cb => cb.ProductoId == productId).ToListAsync();
            _context.CodigoBarras.RemoveRange(codigoBarras);
            await _context.SaveChangesAsync();
        }
    }
}
