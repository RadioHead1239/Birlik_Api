using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities.Siniestros
{
    public class SiniestroVehicular
    {
        [Key]
        public int Id_SiniestroVehicular { get; set; }

        public int Fk_RamoVehicular { get; set; }

        public int Fk_Poliza { get; set; }

        public int Fk_Cliente { get; set; }

        public int Fk_Compania { get; set; }

        public DateTime FechaRegistroSiniestroVehicular { get; set; }

        public DateTime FechaCreacionSiniestroVehicular { get; set; }

        public string Fk_User { get; set; }

        [NotMapped]
        public List<string> RutasFotosSiniestroVehicular { get; set; }

        public SiniestroVehicular()
        {
            RutasFotosSiniestroVehicular = new List<string>();

            RutasDocumentosSiniestroVehicular = new List<string>();
        }

        [NotMapped]
        [DisplayName("Fotos adicionales")]
        public List<IFormFile> FotosAdicionalesSiniestroVehicular { get; set; }

        public string? FotoSiniestroVehicular1 { get; set; }

        public string? FotoSiniestroVehicular2 { get; set; }

        public string? FotoSiniestroVehicular3 { get; set; }

        public string? FotoSiniestroVehicular4 { get; set; }

        public string? FotoSiniestroVehicular5 { get; set; }

        public string? FotoSiniestroVehicular6 { get; set; }

        public string? FotoSiniestroVehicular7 { get; set; }

        public string? FotoSiniestroVehicular8 { get; set; }

        public string? FotoSiniestroVehicular9 { get; set; }

        public string? FotoSiniestroVehicular10 { get; set; }

        public string? FotoSiniestroVehicular11 { get; set; }

        public string? FotoSiniestroVehicular12 { get; set; }

        public string? FotoSiniestroVehicular13 { get; set; }

        public string? FotoSiniestroVehicular14 { get; set; }

        public string? FotoSiniestroVehicular15 { get; set; }

        public DateTime? EntregaUnidadSiniestroVehicular { get; set; }

        public DateTime? SalidaUnidadSiniestroVehicular { get; set; }

        public string? TallerAtencionSiniestroVehicular { get; set; }

        public string? MotivoSiniestroVehicular { get; set; }

        public string? VehiculoOperativoSiniestroVehicular { get; set; }

        public string? PlacaTerceroSiniestroVehicular { get; set; }

        public string? HeridosSiniestroVehicular { get; set; }

        public string? DenunciaPolicialSiniestroVehicular { get; set; }

        public string? MonedaDanioSiniestroVehicular { get; set; }

        [NotMapped]
        public List<string> RutasDocumentosSiniestroVehicular { get; set; }

        [NotMapped]
        [DisplayName("Documentos adicionales")]
        public List<IFormFile> DocumentosAdicionalesSiniestroVehicular { get; set; }

        public string? DocumentoSiniestroVehicular1 { get; set; }

        public string? DocumentoSiniestroVehicular2 { get; set; }

        public string? DocumentoSiniestroVehicular3 { get; set; }

        public string? DocumentoSiniestroVehicular4 { get; set; }

        public string? DocumentoSiniestroVehicular5 { get; set; }

        public string? DocumentoSiniestroVehicular6 { get; set; }

        public string? DocumentoSiniestroVehicular7 { get; set; }

        public string? DocumentoSiniestroVehicular8 { get; set; }

        public string? DocumentoSiniestroVehicular9 { get; set; }

        public string? DocumentoSiniestroVehicular10 { get; set; }

        public string? DocumentoSiniestroVehicular11 { get; set; }

        public string? DocumentoSiniestroVehicular12 { get; set; }

        public string? DocumentoSiniestroVehicular13 { get; set; }

        public string? DocumentoSiniestroVehicular14 { get; set; }

        public string? DocumentoSiniestroVehicular15 { get; set; }

        public decimal? PresupuestoSiniestroVehicular { get; set; }

        public string? DeducibleSiniestroVehicular { get; set; }

        public string? SOATSiniestroVehicular { get; set; }

        public string? GPSSiniestroVehicular { get; set; }

        public string? DañoSiniestroVehicular { get; set; }

        public string? PorcentajeDeducibleSiniestroVehicular { get; set; }

        public decimal? MontoMinimoDeducibleSiniestroVehicular { get; set; }

        public string? ObservacionesVehicular { get; set; }
    }
}
