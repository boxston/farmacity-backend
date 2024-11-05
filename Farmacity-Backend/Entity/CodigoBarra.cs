using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Farmacity_Backend.Entity
{
    public class CodigoBarra
    {
        [ForeignKey("Producto")]
        public int ProductoId { get; set; }
        [Key]
        public string Codigo { get; set; } = null!;
        public bool Activo { get; set; }
        public DateTime FechaAlta { get; set; } = DateTime.UtcNow;
        public Producto Producto { get; set; } = null!;
    }
}
