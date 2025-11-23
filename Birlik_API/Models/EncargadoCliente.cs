using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities
{
    public class EncargadoCliente
    {

        [Key]
        public int Id_Encargado_Cliente { get; set; }

        public string EmailEncargado { get; set; }

        public string CargoEncargado { get; set; }

        public string NombreEncargado { get; set; }

        public string EstadoEncargado { get; set; }

        public string UsoCorreo { get; set; }

        public string TipoEncargadoCliente { get; set; }

        public int Fk_Cliente { get; set; }

        public int Fk_Poliza { get; set; }

    }
}
