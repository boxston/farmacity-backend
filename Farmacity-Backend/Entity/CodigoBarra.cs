using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Farmacity_Backend.Entity
{
    public class CodigoBarra
    {
        [Key, ForeignKey("Producto")]
        public int ProductoId { get; set; }
        public string Codigo { get; set; } = null!;
        public bool Activo { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public Producto Producto { get; set; } = null!;
    }
}
