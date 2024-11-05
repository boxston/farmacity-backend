using Microsoft.EntityFrameworkCore;

namespace Farmacity_Backend.Entity
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public decimal Precio { get; set; }
        public int CantidadEnStock { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public CodigoBarra ? CodigoBarra {  get; set; }
    }
}
