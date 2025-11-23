using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities.Siniestros
{
    public class SiniestroSCTR
    {
        [Key]
        public int Id_SiniestroSCTR { get; set; }

        public int Fk_Poliza { get; set; }

        public int Fk_Cliente { get; set; }

        public int Fk_Compania { get; set; }
        public DateTime FechaRegistroSiniestroSCTR { get; set; }

        public string Fk_User { get; set; }

        [NotMapped]
        public List<string> RutasArchivosSiniestroSCTR { get; set; }

        public SiniestroSCTR()
        {
            RutasArchivosSiniestroSCTR = new List<string>();

            RutasSolicitudesSiniestroSCTR = new List<string>();

            RutasliquidacionSCTR = new List<string>();
        }

        [NotMapped]
        [DisplayName("Archivos adicionales")]
        public List<IFormFile> ArchivosAdicionalesSiniestroSCTR { get; set; }

        public string? ArchivoSiniestroSCTR1 { get; set; }

        public string? ArchivoSiniestroSCTR2 { get; set; }

        public string? ArchivoSiniestroSCTR3 { get; set; }

        public string? ArchivoSiniestroSCTR4 { get; set; }

        public string? ArchivoSiniestroSCTR5 { get; set; }

        public string? ArchivoSiniestroSCTR6 { get; set; }

        public string? ArchivoSiniestroSCTR7 { get; set; }

        public string? ArchivoSiniestroSCTR8 { get; set; }

        public string? ArchivoSiniestroSCTR9 { get; set; }

        public string? ArchivoSiniestroSCTR10 { get; set; }

        public string? ArchivoSiniestroSCTR11 { get; set; }

        public string? ArchivoSiniestroSCTR12 { get; set; }

        public string? ArchivoSiniestroSCTR13 { get; set; }

        public string? ArchivoSiniestroSCTR14 { get; set; }

        public string? ArchivoSiniestroSCTR15 { get; set; }

        public string? descripcionSiniestroSCTR { get; set; }

        public DateTime FechaSiniestroSCTR { get; set; }

        [NotMapped]
        public string FechaSiniestroSCTRFormateada => FechaSiniestroSCTR.ToString("d/M/yyyy");

        public string? DNISiniestroSCTR { get; set; }

        public string? nombresiniestroSCTR { get; set; }

        public string? apepaternosiniestroSCTR { get; set; }

        public string? apematernosiniestroSCTR { get; set; }

        public string? clinicaAtencionSiniestroSCTR { get; set; }

        public string? cartaGarantiaSiniestroSCTR { get; set; }

        public string? descansoMedicoSiniestroSCTR { get; set; }

        public string? trasladoSiniestroSCTR { get; set; }

        public string? tipoSiniestroSCTR { get; set; }

        public string? lugarSiniestroSCTR { get; set; }

        [NotMapped]
        public List<string> RutasSolicitudesSiniestroSCTR { get; set; }

        [NotMapped]
        [DisplayName("Solicitudes adicionales")]
        public List<IFormFile> SolicitudesAdicionalesSiniestroSCTR { get; set; }

        public string? SolicitudSiniestroSCTR1 { get; set; }

        public string? SolicitudSiniestroSCTR2 { get; set; }

        public string? SolicitudSiniestroSCTR3 { get; set; }

        public string? SolicitudSiniestroSCTR4 { get; set; }

        public string? SolicitudSiniestroSCTR5 { get; set; }

        public string? contactoNombreSiniestroSCTR { get; set; }

        public string? contactoApellidoSiniestroSCTR { get; set; }

        public string? contactoEmailSiniestroSCTR { get; set; }

        public string? contactoTelefonoSiniestroSCTR { get; set; }

        public string? contactoCargoSiniestroSCTR { get; set; }

        [NotMapped]
        public List<string> RutasliquidacionSCTR { get; set; }

        [NotMapped]
        [DisplayName("Solicitudes adicionales")]
        public List<IFormFile> liquidacionSCTRFile { get; set; }

        public string? liquidacionSCTR { get; set; }    

        public int Fk_RamoSctr { get; set; }

        public string? ObservacionSCTR { get; set; }
    }
}
