using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities.Siniestros
{
    public class SiniestroCar
    {
        [Key]
        public int Id_SiniestroCar { get; set; }

        public int Fk_RamoCar { get; set; }
        public int Fk_Poliza { get; set; }

        public int Fk_Cliente { get; set; }

        public int Fk_Compania { get; set; }

        public DateTime FechaRegistroSiniestroCar { get; set; }

        public DateTime? FechaReporteCompaniaSiniestroCar { get; set; }

        public DateTime FechaCreacionSiniestroCar { get; set; }

        public string Fk_User { get; set; }

        [NotMapped]
        public List<string> RutasFotosSiniestroCar { get; set; }

        public SiniestroCar()
        {
            RutasFotosSiniestroCar = new List<string>();

            RutasInformesSiniestroCar = new List<string>();

            RutasDocumentosSiniestroCar = new List<string>();

            RutasCartasSiniestroCar = new List<string>();

            RutasReportesSiniestroCar = new List<string>();

            RutasInformesFinalesSiniestroCar = new List<string>();
        }

        [NotMapped]
        [DisplayName("Fotos adicionales")]
        public List<IFormFile> FotosAdicionalesSiniestroCar { get; set; }

        public string? FotoSiniestroCar1 { get; set; }

        public string? FotoSiniestroCar2 { get; set; }

        public string? FotoSiniestroCar3 { get; set; }

        public string? FotoSiniestroCar4 { get; set; }

        public string? FotoSiniestroCar5 { get; set; }

        public string? FotoSiniestroCar6 { get; set; }

        public string? FotoSiniestroCar7 { get; set; }

        public string? FotoSiniestroCar8 { get; set; }

        public string? FotoSiniestroCar9 { get; set; }

        public string? FotoSiniestroCar10 { get; set; }

        public string? FotoSiniestroCar11 { get; set; }

        public string? FotoSiniestroCar12 { get; set; }

        public string? FotoSiniestroCar13 { get; set; }

        public string? FotoSiniestroCar14 { get; set; }

        public string? FotoSiniestroCar15 { get; set; }

        public string? NombrePersonaReporteSiniestroCar { get; set; }

        public string? CelularPersonaReporteSiniestroCar { get; set; }

        public string? CelularPersonaEncargadaSiniestroCar { get; set; }

        public string? CorreoPersonaEncargadaSiniestroCar { get; set; }

        public string? LugarSiniestroCar { get; set; }

        public string? DescripcionSiniestroCar { get; set; }

        public string? DatoAjustadorSiniestroCar { get; set; }

        public string? NumeroAjusteSiniestroCar { get; set; }

        public string? ConclusionCIASEGUROSiniestroCar { get; set; }

        public string? ObservacionSiniestroCar { get; set; }

        public DateTime? FechaAbonoIndemnizacionSiniestroCar { get; set; }

        public decimal? MontoReclamacionSiniestroCar { get; set; }

        [NotMapped]
        public List<string> RutasDocumentosSiniestroCar { get; set; }

        [NotMapped]
        [DisplayName("Documentos adicionales")]
        public List<IFormFile> DocumentosAdicionalesSiniestroCar { get; set; }

        public string? DocumentoSiniestroCar1 { get; set; }

        public string? DocumentoSiniestroCar2 { get; set; }

        public string? DocumentoSiniestroCar3 { get; set; }

        public string? DocumentoSiniestroCar4 { get; set; }

        public string? DocumentoSiniestroCar5 { get; set; }

        public string? DocumentoSiniestroCar6 { get; set; }

        public string? DocumentoSiniestroCar7 { get; set; }

        public string? DocumentoSiniestroCar8 { get; set; }

        public string? DocumentoSiniestroCar9 { get; set; }

        public string? DocumentoSiniestroCar10 { get; set; }

        public string? DocumentoSiniestroCar11 { get; set; }

        public string? DocumentoSiniestroCar12 { get; set; }

        public string? DocumentoSiniestroCar13 { get; set; }

        public string? DocumentoSiniestroCar14 { get; set; }

        public string? DocumentoSiniestroCar15 { get; set; }

        [NotMapped]
        public List<string> RutasInformesSiniestroCar { get; set; }

        [NotMapped]
        [DisplayName("Informes adicionales")]
        public List<IFormFile> InformesAdicionalesSiniestroCar { get; set; }

        public string? InformeSiniestroCar1 { get; set; }

        public string? InformeSiniestroCar2 { get; set; }

        public string? InformeSiniestroCar3 { get; set; }

        public string? InformeSiniestroCar4 { get; set; }

        public string? InformeSiniestroCar5 { get; set; }

        [NotMapped]
        public List<string> RutasCartasSiniestroCar { get; set; }

        [NotMapped]
        [DisplayName("Cartas adicionales")]
        public List<IFormFile> CartasAdicionalesSiniestroCar { get; set; }

        public string? CartaSiniestroCar1 { get; set; }

        public string? CartaSiniestroCar2 { get; set; }

        public string? CartaSiniestroCar3 { get; set; }

        public string? CartaSiniestroCar4 { get; set; }

        public string? CartaSiniestroCar5 { get; set; }

        [NotMapped]
        public List<string> RutasInformesFinalesSiniestroCar { get; set; }

        [NotMapped]
        [DisplayName("Cartas adicionales")]
        public List<IFormFile> InformesFinalesSiniestroCar { get; set; }

        public string? InformeFinalSiniestroCar1 { get; set; }

        public string? InformeFinalSiniestroCar2 { get; set; }

        public string? InformeFinalSiniestroCar3 { get; set; }

        public string? InformeFinalSiniestroCar4 { get; set; }

        public string? InformeFinalSiniestroCar5 { get; set; }

        [NotMapped]
        public List<string> RutasReportesSiniestroCar { get; set; }

        [NotMapped]
        [DisplayName("Cartas adicionales")]
        public List<IFormFile> ReportesAdicionalesSiniestroCar { get; set; }

        public string? ReporteDaniosSiniestroCar1 { get; set; }

        public string? ReporteDaniosSiniestroCar2 { get; set; }

        public string? ReporteDaniosSiniestroCar3 { get; set; }

        public string? ReporteDaniosSiniestroCar4 { get; set; }

        public string? ReporteDaniosSiniestroCar5 { get; set; }

        public decimal? MontoIndemnizacionSiniestroCar { get; set; }

        public string? MonedaReclamacionSiniestroCar { get; set; }

        public string? MonedaIndemnizacionSiniestroCar { get; set; }

        public string? DeducibleSiniestroCar { get; set; }

        public string? PorcentajeDeducibleSiniestroCar { get; set; }

        public decimal? MontoMinimoDeducibleSiniestroCar { get; set; }

        public string? ObservacionCar { get; set; }

    }
}
