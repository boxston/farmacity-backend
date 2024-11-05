using Farmacity_Backend.Entity;

namespace Farmacity_Backend.Interfaces
{
    public interface ICodigoBarraRepository
    {
        public Task<Boolean> AddRangeAsync(IEnumerable<CodigoBarra> codigoBarras);
        public Task DeleteByProductIdAsync(int productId);
    }
}
