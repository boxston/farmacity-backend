namespace Farmacity_Backend.DTOs
{
    public class CodigoBarraDTO
    {
        public string Codigo { get; set; } = null!;
        public bool Activo { get; set; }

        public DateTime? FechaAlta { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
