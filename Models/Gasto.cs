namespace FinanzasFamiliares.Models
{
    public class Gasto
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }
        public string Categoria { get; set; } = string.Empty; // Inicializa la propiedad
        public string UsuarioId { get; set; } = string.Empty; // Inicializa la propiedad
    }
}
