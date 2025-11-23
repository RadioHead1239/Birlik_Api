using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities
{
    public class CorreoPorCliente
    {
        [Key]
        public int Id_CorreoPorCliente { get; set; }

        public string NombresContacto { get; set; }

        public string CargoContacto { get; set; }

        public string Correo { get; set; }

        public string EstadoContacto { get; set; }

        public int Fk_Cliente { get; set; }

    }
}
