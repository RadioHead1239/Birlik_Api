using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities
{
    public class Autorizacion
    {

        [Key]
        public int Id_Autorizacion { get; set; }

        public string TipoAutorizacion { get; set; }


        public int Fk_Poliza { get; set; }

        public string EstadoAutorizacion { get; set; }

        public DateTime FechaAutorizacion { get; set; }

        public string Fk_Usuario { get; set; }

        public int Fk_Cliente { get; set; }

        public int Fk_Cuota { get; set; }

    }
}
