using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities
{
    public class Anuncio
    {
        [Key]
        public int Id_Anuncio { get; set; }

        public string TipoAnuncio { get; set; }

        public string CuerpoAnuncio { get; set; }

        public string AsuntoAnuncio { get; set; }

        public string Destinatarios { get; set; }

        public int CantidadVeces { get; set; }

        public int RealizadasVeces { get; set; }

        public DateTime FechaRegistro { get; set; }

    }
}
