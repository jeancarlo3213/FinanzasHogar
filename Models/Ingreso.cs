﻿namespace FinanzasHogar.Models
{
    public class Ingreso
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }
        public string Categoria { get; set; } = string.Empty; // Inicializa la propiedad
        public string UsuarioId { get; set; } = string.Empty; // Inicializa la propiedad
    }
}

