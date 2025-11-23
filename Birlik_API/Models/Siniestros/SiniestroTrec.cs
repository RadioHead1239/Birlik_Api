using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities.Siniestros
{
    public class SiniestroTrec
    {

        [Key]
        public int Id_SiniestroTrec { get; set; }

        public int Fk_RamoTrec { get; set; }
        public int Fk_Poliza { get; set; }

        public int Fk_Cliente { get; set; }

        public int Fk_Compania { get; set; }

        public DateTime FechaRegistroSiniestroTrec { get; set; }

        public DateTime? FechaReporteCompaniaSiniestroTrec { get; set; }

        public DateTime FechaCreacionSiniestroTrec { get; set; }

        public string Fk_User { get; set; }

        [NotMapped]
        public List<string> RutasFotosSiniestroTrec { get; set; }

        public SiniestroTrec()
        {
            RutasFotosSiniestroTrec = new List<string>();

            RutasDocumentosSiniestroTrec = new List<string>();

            RutasCartasSiniestroTrec = new List<string>();

            RutasInformesSiniestroTrec = new List<string>();
        }

        [NotMapped]
        [DisplayName("Fotos adicionales")]
        public List<IFormFile> FotosAdicionalesSiniestroTrec { get; set; }

        public string? FotoSiniestroTrec1 { get; set; }

        public string? FotoSiniestroTrec2 { get; set; }

        public string? FotoSiniestroTrec3 { get; set; }

        public string? FotoSiniestroTrec4 { get; set; }

        public string? FotoSiniestroTrec5 { get; set; }

        public string? FotoSiniestroTrec6 { get; set; }

        public string? FotoSiniestroTrec7 { get; set; }

        public string? FotoSiniestroTrec8 { get; set; }

        public string? FotoSiniestroTrec9 { get; set; }

        public string? FotoSiniestroTrec10 { get; set; }

        public string? FotoSiniestroTrec11 { get; set; }

        public string? FotoSiniestroTrec12 { get; set; }

        public string? FotoSiniestroTrec13 { get; set; }

        public string? FotoSiniestroTrec14 { get; set; }

        public string? FotoSiniestroTrec15 { get; set; }

        public string? NombrePersonaReportoSiniestroTrec { get; set; }

        public string? CelularPersonaReportoSiniestroTrec { get; set; }

        public string? CelularPersonaEncargadaSiniestroTrec { get; set; }

        public string? CorreoPersonaEncargadaSiniestroTrec { get; set; }

        public string? LugarSiniestroTrec { get; set; }

        public string? DescripcionSiniestroTrec { get; set; }

        public string? DatosAjustadorSiniestroTrec { get; set; }

        public string? NumeroAjusteSiniestroTrec { get; set; }

        public string? ConclusionCIASEGUROSiniestroTrec { get; set; }

        public string? ObservacionSiniestroTrec { get; set; }

        public DateTime? FechaAbonoIndemnizacionSiniestroTrec { get; set; }

        public decimal? MontoReclamadoSiniestroTrec { get; set; }

        [NotMapped]
        public List<string> RutasDocumentosSiniestroTrec { get; set; }

        [NotMapped]
        [DisplayName("Documentos adicionales")]
        public List<IFormFile> DocumentosAdicionalesSiniestroTrec { get; set; }

        public string? DocumentoSiniestroTrec1 { get; set; }

        public string? DocumentoSiniestroTrec2 { get; set; }

        public string? DocumentoSiniestroTrec3 { get; set; }

        public string? DocumentoSiniestroTrec4 { get; set; }

        public string? DocumentoSiniestroTrec5 { get; set; }

        public string? DocumentoSiniestroTrec6 { get; set; }

        public string? DocumentoSiniestroTrec7 { get; set; }

        public string? DocumentoSiniestroTrec8 { get; set; }

        public string? DocumentoSiniestroTrec9 { get; set; }

        public string? DocumentoSiniestroTrec10 { get; set; }

        public string? DocumentoSiniestroTrec11 { get; set; }

        public string? DocumentoSiniestroTrec12 { get; set; }

        public string? DocumentoSiniestroTrec13 { get; set; }

        public string? DocumentoSiniestroTrec14 { get; set; }

        public string? DocumentoSiniestroTrec15 { get; set; }

        [NotMapped]
        public List<string> RutasInformesSiniestroTrec { get; set; }

        [NotMapped]
        [DisplayName("Informes adicionales")]
        public List<IFormFile> InformesAdicionalesSiniestroTrec { get; set; }

        public string? InformeSiniestroTrec1 { get; set; }

        public string? InformeSiniestroTrec2 { get; set; }

        public string? InformeSiniestroTrec3 { get; set; }

        public string? InformeSiniestroTrec4 { get; set; }

        public string? InformeSiniestroTrec5 { get; set; }

        [NotMapped]
        public List<string> RutasCartasSiniestroTrec { get; set; }

        [NotMapped]
        [DisplayName("Cartas adicionales")]
        public List<IFormFile> CartasAdicionalesSiniestroTrec { get; set; }

        public string? CartaSiniestroTrec1 { get; set; }

        public string? CartaSiniestroTrec2 { get; set; }

        public string? CartaSiniestroTrec3 { get; set; }

        public string? CartaSiniestroTrec4 { get; set; }

        public string? CartaSiniestroTrec5 { get; set; }

        public decimal? MontoIndenminazcionSiniestroTrec { get; set; }

        public string? MonedaIndemnizacionSiniestroTrec { get; set; }

        public string? MonedaReclamacionSiniestroTrec { get; set; }

        public string? DeducibleSiniestroTrec { get; set; }

        public string? PorcentajeDeducibleSiniestroTrec { get; set; }

        public decimal? MontoMinimoDeducibleSiniestroTrec { get; set; }

        public string? ObservacionTrec { get; set; }

    }
}
