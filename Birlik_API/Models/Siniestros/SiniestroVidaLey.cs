using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Birlik.Models.Entities.Siniestros
{
    public class SiniestroVidaLey
    {
        [Key]
        public int Id_SiniestroVidaLey { get; set; }

        public int Fk_Poliza { get; set; }

        public int Fk_Cliente { get; set; }

        public int Fk_Compania { get; set; }

        public int Fk_RamoVida { get; set; }
        public DateTime FechaRegistroSiniestroVidaLey { get; set; }

        public string Fk_User { get; set; }

        [NotMapped]
        public List<string> RutasArchivosSiniestroVidaLey { get; set; }

        public SiniestroVidaLey()
        {
            RutasArchivosSiniestroVidaLey = new List<string>();

            RutasSolicitudesSiniestroVidaLey = new List<string>();

            RutasCoberturaSiniestroVidaLey = new List<string>();
        }

        [NotMapped]
        [DisplayName("Archivos adicionales")]
        public List<IFormFile> ArchivosAdicionalesSiniestroVidaLey { get; set; }

        public string? ArchivoSiniestroVidaLey1 { get; set; }

        public string? ArchivoSiniestroVidaLey2 { get; set; }

        public string? ArchivoSiniestroVidaLey3 { get; set; }

        public string? ArchivoSiniestroVidaLey4 { get; set; }

        public string? ArchivoSiniestroVidaLey5 { get; set; }

        public string? ArchivoSiniestroVidaLey6 { get; set; }

        public string? ArchivoSiniestroVidaLey7 { get; set; }

        public string? ArchivoSiniestroVidaLey8 { get; set; }

        public string? ArchivoSiniestroVidaLey9 { get; set; }

        public string? ArchivoSiniestroVidaLey10 { get; set; }

        public string? ArchivoSiniestroVidaLey11 { get; set; }

        public string? ArchivoSiniestroVidaLey12 { get; set; }

        public string? ArchivoSiniestroVidaLey13 { get; set; }

        public string? ArchivoSiniestroVidaLey14 { get; set; }

        public string? ArchivoSiniestroVidaLey15 { get; set; }

        public string? DescripcionSucedidoSiniestroVidaLey { get; set; }

        public DateTime FechaAvisoSiniestroVidaLey { get; set; }

        public DateTime FechaDecesoSiniestroVidaLey { get; set; }

        public string? DNISiniestroVidaLey { get; set; }

        public string? MotivoFallecimientoSiniestroVidaLey { get; set; }

        public string? CausaFallecimientoSiniestroVidaLey { get; set; }

        public string? CoberturaAdicionalSiniestroVidaLey { get; set; }

        [NotMapped]
        public List<string> RutasSolicitudesSiniestroVidaLey { get; set; }

        public string? nombresiniestroVidaLey { get; set; }

        public string? apepaternoVidaLey { get; set; }

        public string? apematernoVidaLey { get; set; }

        [NotMapped]
        [DisplayName("Solicitudes adicionales")]
        public List<IFormFile> SolicitudesAdicionalesSiniestroVidaLey { get; set; }

        public string? SolicitudSiniestroVidaLey1 { get; set; }

        public string? SolicitudSiniestroVidaLey2 { get; set; }

        public string? SolicitudSiniestroVidaLey3 { get; set; }
        public string? SolicitudSiniestroVidaLey4 { get; set; }
        public string? SolicitudSiniestroVidaLey5 { get; set; }

        public string? contactoNombreSiniestroVidaLey { get; set; }

        public string? contactoApellidoSiniestroVidaLey { get; set; }

        public string? contactoEmailSiniestroVidaLey { get; set; }

        public string? contactoTelefonoSiniestroVidaLey { get; set; }

        public string? contactoCargoSiniestroVidaLey { get; set; }

        [NotMapped]
        public List<string> RutasCoberturaSiniestroVidaLey { get; set; }

        [NotMapped]
        [DisplayName("Coberturas adicionales")]
        public List<IFormFile> CoberturasAdicionalesSiniestroVidaLey { get; set; }

        public string? CoberturaSiniestroVidaLey1 { get; set; }

        public string? CoberturaSiniestroVidaLey2 { get; set; }

        public string? CoberturaSiniestroVidaLey3 { get; set; }

        public string? CoberturaSiniestroVidaLey4 { get; set; }

        public string? CoberturaSiniestroVidaLey5 { get; set; }

        public string? encargadaNombreSiniestroVidaLey { get; set; }

        public string? encargadaApellidoSiniestroVidaLey { get; set; }

        public string? encargadaEmailSiniestroVidaLey { get; set; }

        public string? encargadaTelefonoSiniestroVidaLey { get; set; }

        public string? encargadaCargoSiniestroVidaLey { get; set; }

        public string? ObservacionVidaLey { get; set; }

    }
}
