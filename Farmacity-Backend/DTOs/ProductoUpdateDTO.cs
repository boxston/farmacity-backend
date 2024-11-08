﻿using System.ComponentModel.DataAnnotations;

namespace Farmacity_Backend.DTOs
{
    public class ProductoUpdateDTO
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string? Nombre { get; set; } = null!;
        public decimal? Precio { get; set; }
        public int? CantidadEnStock { get; set; }
        public bool? Activo { get; set; }
        public DateTime? fechaAlta { get; set; }
        public DateTime? fechaModificacion { get; set; }
        public List<CodigoBarraDTO> CodigoBarras { get; set; } = new List<CodigoBarraDTO>();
    }
}
