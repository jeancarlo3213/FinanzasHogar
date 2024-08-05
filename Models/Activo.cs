using System;
using System.ComponentModel.DataAnnotations;

namespace FinanzasHogar.Models
{
    public class Activo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El tipo es obligatorio.")]
        public string Tipo { get; set; } = string.Empty;

        [Required(ErrorMessage = "El detalle es obligatorio.")]
        public string Detalle { get; set; } = string.Empty;

        public string Descripcion { get; set; } = string.Empty;

        [Required(ErrorMessage = "El valor es obligatorio.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "El valor debe ser mayor que 0.")]
        public decimal Valor { get; set; }

        public string UsuarioId { get; set; } = string.Empty;

        public string Ubicacion { get; set; } = string.Empty;

        [Required(ErrorMessage = "La fecha de adquisición es obligatoria.")]
        public DateTime FechaAdquisicion { get; set; }

        [Required(ErrorMessage = "La condición es obligatoria.")]
        public string Condicion { get; set; } = string.Empty;
    }
}
