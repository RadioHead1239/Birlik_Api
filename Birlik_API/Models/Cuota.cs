using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Birlik.Models.Entities
{
    public class Cuota
    {
        [Key]
        public int Id_Cuota { get; set; }

        public int Numero_Cuota { get; set; } //el numero de la cuota, por ejemplo cuota 2

        public int CodigoCuota { get; set; }

        [DataType(DataType.Date)]// Me va a traer solo la fecha mas no la hora
        public DateTime VencimientoCuota { get; set; }

        public decimal Importe { get; set; }

        [DataType(DataType.Date)]// Me va a traer solo la fecha mas no la hora
        public DateTime? FechaPago { get; set; }

        public string? NumeroFactura { get; set; }

        public string? ObservacionCuota { get; set; }

        public string EstadoCuota { get; set; }

        public DateTime FechaRegistroCuota { get; set; }

        //ANEXANDO A TABLAS
        public int Fk_Cliente { get; set; }

        public int Fk_Poliza { get; set; }

        public int Fk_Prima { get; set; }

        public int Cantidad_Cuotas { get; set; }

        public string? DocumentoCuota { get; set; }

        public string? DocumentoXMLCuota { get; set; }

        [NotMapped]//NO ES COLUMNA
        [DisplayName("Upload File")]
        public IFormFile DocumentoFile { get; set; }

        [NotMapped]//NO ES COLUMNA
        [DisplayName("Upload File")]
        public IFormFile DocumentoFileXML { get; set; }

        public string? ComprobantePago { get; set; }

        [NotMapped]//NO ES COLUMNA
        [DisplayName("Upload File")]
        public IFormFile DocumentoFile_Comprobante { get; set; }

        public int MsjEnviados { get; set; }

        public string Prefijo { get; set; }

        public string TipoFactura { get; set; }

        public string? ConstanciaSunat { get; set; }

        [NotMapped]//NO ES COLUMNA
        [DisplayName("Upload File")]
        public IFormFile DocumentoFile_ConstanciaSunat { get; set; }

        public DateTime? FechaRegistroCancelacion { get; set; }

        public string? Cancelacion_Usuario { get; set; }

        public string? UsuarioFactura { get; set; } = string.Empty;

        public string? UsuarioCobranza { get; set; } = string.Empty;

        public string EnviarConfirmacion { get; set; } = "No-Mostrar";

        public string? EstadoActual { get; set; } = string.Empty;

    }
}
