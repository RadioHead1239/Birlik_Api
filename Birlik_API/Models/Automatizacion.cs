using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities
{
    public class Automatizacion
    {

        [Key]
        public int Id_Automatizacion { get; set; }

        public string TipoAutomatizacion { get; set; }

        public string DescripcionAutomatizacion { get; set; }

        public string EstadoAutomatizacion { get; set; }

        public string Asunto { get; set; }

        public string ConCopia { get; set; }

        public string CorreoEmisor { get; set; }

        public string ObservacionAutomatizacion { get; set; }

        public string CabeceraUrl { get; set; }

        public string FirmaCorreo { get; set; }


    }
}
