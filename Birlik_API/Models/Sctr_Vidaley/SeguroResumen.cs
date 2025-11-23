using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Birlik.Models.Entities.Sctr_Vidaley
{
    public class SeguroResumen
    {

        [Key]
        public int Id_SeguroResumen { get; set; }

        [DataType(DataType.Date)]// Me va a traer solo la fecha mas no la hora
        public DateTime FechaCreacionSeguro { get; set; }

        public DateTime FechaRegistroSeguro { get; set; }

        public string EstadoSeguro { get; set; } // Pendiente - Atendido

        public string EstadoAtencion { get; set; } // Excel enviado - Procesando atencion - pdf generado

        public string DocumentoSeguro { get; set; }

        public int CantidadTrabajadores { get; set; }

        public string usuario { get; set; }

        public int Fk_Cliente { get; set; }

        public int Fk_Poliza { get; set; }

        public decimal SueldoTotal { get; set; }

        [NotMapped]//NO ES COLUMNA
        public string TipoSeguro { get; internal set; }
    }
}
