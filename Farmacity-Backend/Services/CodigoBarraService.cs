using Farmacity_Backend.Entity;
using Farmacity_Backend.Interfaces;

namespace Farmacity_Backend.Services
{
    public class CodigoBarraService
    {
        private readonly ICodigoBarraRepository _codigoBarraRepository;

        public CodigoBarraService(ICodigoBarraRepository codigoBarraRepository)
        {
            _codigoBarraRepository = codigoBarraRepository;
        }
    }
}
