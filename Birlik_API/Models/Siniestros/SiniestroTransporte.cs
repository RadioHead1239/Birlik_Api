using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities.Siniestros
{
    public class SiniestroTransporte
    {

        [Key]
        public int Id_SiniestroTransporte { get; set; }

        public int Fk_RamoTransporte { get; set; }

        public int Fk_Poliza { get; set; }


        public int Fk_Cliente { get; set; }

        public int Fk_Compania { get; set; }

        public DateTime FechaRegistroSiniestroTransporte { get; set; }

        public DateTime? FechaReporteCompaniaSiniestroTransporte { get; set; }

        public DateTime FechaCreacionSiniestroTransporte { get; set; }

        public string Fk_User { get; set; }

        [NotMapped]
        public List<string> RutasFotosSiniestroTransporte { get; set; }

        public SiniestroTransporte()
        {
            RutasFotosSiniestroTransporte = new List<string>();

            RutasDocumentosSiniestroTransporte = new List<string>();

            RutasCartasSiniestroTransporte = new List<string>();

            RutasInformesSiniestroTransporte = new List<string>();
        }

        [NotMapped]
        [DisplayName("Fotos adicionales")]
        public List<IFormFile> FotosAdicionalesSiniestroTransporte { get; set; }

        public string? FotoSiniestroTransporte1 { get; set; }

        public string? FotoSiniestroTransporte2 { get; set; }

        public string? FotoSiniestroTransporte3 { get; set; }

        public string? FotoSiniestroTransporte4 { get; set; }

        public string? FotoSiniestroTransporte5 { get; set; }

        public string? FotoSiniestroTransporte6 { get; set; }

        public string? FotoSiniestroTransporte7 { get; set; }

        public string? FotoSiniestroTransporte8 { get; set; }

        public string? FotoSiniestroTransporte9 { get; set; }

        public string? FotoSiniestroTransporte10 { get; set; }

        public string? FotoSiniestroTransporte11 { get; set; }

        public string? FotoSiniestroTransporte12 { get; set; }

        public string? FotoSiniestroTransporte13 { get; set; }

        public string? FotoSiniestroTransporte14 { get; set; }

        public string? FotoSiniestroTransporte15 { get; set; }

        public string? NombrePersonaReportoSiniestroTransporte { get; set; }

        public string? CelularPersonaReportoSiniestroTransporte { get; set; }

        public string? CelularPersonaEncargadaSiniestroTransporte { get; set; }

        public string? CorreoPersonaEncargadaSiniestroTransporte { get; set; }

        public string? LugarSiniestroTransporte { get; set; }

        public string? DescripcionSiniestroTransporte { get; set; }

        public string? DatosAjustadorSiniestroTransporte { get; set; }

        public string? NumeroAjusteSiniestroTransporte { get; set; }

        public string? ConclusionCIASEGUROSiniestroTransporte { get; set; }

        public string? ObservacionSiniestroTransporte { get; set; }

        public DateTime? FechaAbonoIndemnizacionSiniestroTransporte { get; set; }

        public decimal? MontoReclamacionSiniestroTransporte { get; set; }

        [NotMapped]
        public List<string> RutasDocumentosSiniestroTransporte { get; set; }

        [NotMapped]
        [DisplayName("Documentos adicionales")]
        public List<IFormFile> DocumentosAdicionalesSiniestroTransporte { get; set; }

        public string? DocumentoSiniestroTransporte1 { get; set; }

        public string? DocumentoSiniestroTransporte2 { get; set; }

        public string? DocumentoSiniestroTransporte3 { get; set; }

        public string? DocumentoSiniestroTransporte4 { get; set; }

        public string? DocumentoSiniestroTransporte5 { get; set; }

        public string? DocumentoSiniestroTransporte6 { get; set; }

        public string? DocumentoSiniestroTransporte7 { get; set; }

        public string? DocumentoSiniestroTransporte8 { get; set; }

        public string? DocumentoSiniestroTransporte9 { get; set; }

        public string? DocumentoSiniestroTransporte10 { get; set; }

        public string? DocumentoSiniestroTransporte11 { get; set; }

        public string? DocumentoSiniestroTransporte12 { get; set; }

        public string? DocumentoSiniestroTransporte13 { get; set; }

        public string? DocumentoSiniestroTransporte14 { get; set; }

        public string? DocumentoSiniestroTransporte15 { get; set; }

        [NotMapped]
        public List<string> RutasInformesSiniestroTransporte { get; set; }

        [NotMapped]
        [DisplayName("Informes adicionales")]
        public List<IFormFile> InformesAdicionalesSiniestroTransporte { get; set; }

        public string? InformeSiniestroTransporte1 { get; set; }

        public string? InformeSiniestroTransporte2 { get; set; }

        public string? InformeSiniestroTransporte3 { get; set; }

        public string? InformeSiniestroTransporte4 { get; set; }

        public string? InformeSiniestroTransporte5 { get; set; }

        [NotMapped]
        public List<string> RutasCartasSiniestroTransporte { get; set; }

        [NotMapped]
        [DisplayName("Cartas adicionales")]
        public List<IFormFile> CartasAdicionalesSiniestroTransporte { get; set; }

        public string? CartaSiniestroTransporte1 { get; set; }

        public string? CartaSiniestroTransporte2 { get; set; }

        public string? CartaSiniestroTransporte3 { get; set; }

        public string? CartaSiniestroTransporte4 { get; set; }

        public string? CartaSiniestroTransporte5 { get; set; }

        public decimal? MontoIndemnizacionSiniestroTransporte { get; set; }

        public string? MonedaIndemnizacionSiniestroTransporte { get; set; }

        public string? MonedaReclamacionSiniestroTransporte { get; set; }

        public string? DeducibleSiniestroTransporte { get; set; }

        public string? PorcentajeDeducibleSiniestroTransporte { get; set; }

        public decimal? MontoMinimoDeducibleSiniestroTransporte { get; set; }

        public string? ObservacionTranporte { get; set; }

    }
}
