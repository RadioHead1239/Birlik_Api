using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities.Rpa
{
    public class SeguroRPATemp
    {
        [Key]
        public int Id_SeguroRPATemp { get; set; }

        public int NumeroProforma { get; set; }

        public string NumeroPoliza { get; set; }

        public decimal Monto { get; set; }

        public string FechaFactura { get; set; }

        public string TipoDocumento { get; set; }

        public string NumeroDocumento { get; set; }

        public string Fk_Usuario { get; set; }


    }
}
