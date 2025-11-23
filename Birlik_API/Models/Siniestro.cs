using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Birlik.Models.Entities
{
    public class Siniestro
    {
        [Key]
        public int Id_Siniestro { get; set; }

        public DateTime FechaSiniestro { get; set; }

        public string? FotoSiniestro1 { get; set; }

        public string? FotoSiniestro2 { get; set; }

        public string? FotoSiniestro3 { get; set; }

        public string? FotoSiniestro4 { get; set; }

        public string? FotoSiniestro5 { get; set; }

        public string? FotoSiniestro6 { get; set; }

        public string? FotoSiniestro7 { get; set; }

        public string? FotoSiniestro8 { get; set; }

        public string? FotoSiniestro9 { get; set; }

        public string? FotoSiniestro10 { get; set; }

        public string? FotoSiniestro11 { get; set; }

        public string? FotoSiniestro12 { get; set; }

        public string? FotoSiniestro13 { get; set; }

        public string? FotoSiniestro14 { get; set; }

        public string? FotoSiniestro15 { get; set; }

        public string TallerAtencionSiniestro { get; set; }

        public string MotivoSiniestro { get; set; }

        public decimal? PresupuestoDanio { get; set; }

        //public string DenunciaPolicial { get; set; }

        public DateTime? FechaSalidaUnidad { get; set; }

        public DateTime? FechaEntregUnidad { get; set; }

        public int Fk_Poliza { get; set; }

        public DateTime FechaCreacionSiniestro { get; set; }

        public string Fk_User { get; set; }

        [NotMapped] 
        [DisplayName("Archivos adicionales")]
        public List<IFormFile> FotosAdicionales { get; set; }

        [NotMapped] // No es una columna en la base de datos
        public List<string> RutasFotos { get; set; }

        public Siniestro()
        {
            RutasFotos = new List<string>();

            RutasDocumentos = new List<string>();
        }

        public string denunciaPolicial { get; set; }

        public string vehicuOperativo { get; set; }

        public string atencionCon { get; set; }

        public string placaTercero { get; set; }

        public string heridos { get; set; }

        [NotMapped] // No es una columna en la base de datos
        public string FechaSiniestroFormateada => FechaSiniestro.ToString("d/M/yyyy");

        public string monedaDanio { get; set; }

        [NotMapped] // No es una columna en la base de datos
        [DisplayName("Documentos adicionales")]
        public List<IFormFile> DocumentosAdicionales { get; set; }

        [NotMapped] // No es una columna en la base de datos
        public List<string> RutasDocumentos { get; set; }

        public string? DocumentoSiniestro1 { get; set; }

        public string? DocumentoSiniestro2 { get; set; }

        public string? DocumentoSiniestro4 { get; set; }

        public string? DocumentoSiniestro3 { get; set; }

        public string? DocumentoSiniestro5 { get; set; }

        public string? DocumentoSiniestro6 { get; set; }

        public string? DocumentoSiniestro7 { get; set; }

        public string? DocumentoSiniestro8 { get; set; }

        public string? DocumentoSiniestro9 { get; set; }

        public string? DocumentoSiniestro10 { get; set; }

        public string? DocumentoSiniestro11 { get; set; }

        public string? DocumentoSiniestro12 { get; set; }

        public string? DocumentoSiniestro13 { get; set; }

        public string? DocumentoSiniestro14 { get; set; }

        public string? DocumentoSiniestro15 { get; set; }

    }
}
