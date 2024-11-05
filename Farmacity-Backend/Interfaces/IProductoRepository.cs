using Farmacity_Backend.Entity;

namespace Farmacity_Backend.Interfaces
{
    public interface IProductoRepository
    {
        public Task<IEnumerable<Producto>> GetAllAsync();
        public Task<Producto> GetByIdAsync(int id);
        public Task AddAsync(Producto producto);
        public Task UpdateAsync(Producto producto);
        public Task DeleteAsync(int id);
    }
}
