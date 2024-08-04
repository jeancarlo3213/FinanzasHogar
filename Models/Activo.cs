namespace FinanzasHogar.Models
{
    public class Activo
    {
        public int Id { get; set; }
        public string Tipo { get; set; } = string.Empty; // Inicializa la propiedad
        public string Detalle { get; set; } = string.Empty; // Inicializa la propiedad
        public string Descripcion { get; set; } = string.Empty; // Nueva propiedad
        public decimal Valor { get; set; }
        public string UsuarioId { get; set; } = string.Empty; // Inicializa la propiedad
        public string Ubicacion { get; set; } = string.Empty; // Nueva propiedad
        public DateTime FechaAdquisicion { get; set; } // Nueva propiedad
        public string Condicion { get; set; } = string.Empty; // Nueva propiedad
    }

}
