namespace FinanzasHogar.Models
{
    public class Pasivo
    {
        public int Id { get; set; }
        public string Tipo { get; set; } = string.Empty; // Inicializa la propiedad
        public string Detalle { get; set; } = string.Empty; // Inicializa la propiedad
        public decimal Monto { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string UsuarioId { get; set; } = string.Empty; // Inicializa la propiedad
    }
}
