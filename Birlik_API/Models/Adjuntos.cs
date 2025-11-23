using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities
{
    public class Adjuntos
    {
        [Key]
        public int Id { get; set; } // Primary Key
        public int CorreoId { get; set; } // Foreign Key
        public string Nombre { get; set; }
        public int Tamaño { get; set; }
        public string LinkDescarga { get; set; }

        // Relación con correos
        //public HistorialCorreos Correo { get; set; }

    }
}
