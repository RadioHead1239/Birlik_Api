using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities
{
    public class Factura
    {
        [Key]
        public int Id_Factura { get; set; }

        public int NumeroFactura { get; set; }

        public string TipoFactura { get; set; }

        public DateTime FechaEmision { get; set; }

        public int Fk_compania { get; set; }

        public string Concepto { get; set; }

        public int NumeroLiquidacion { get; set; }

        public int IGV { get; set; }

        public string Moneda { get; set; }

        public decimal ImporteNeto { get; set; }

        public decimal ImporteIGV { get; set; }

        public decimal ImporteTotal { get; set; }

        public decimal ImporteDetraccion { get; set; }

        public int NumeroDetraccion { get; set; }

        public DateTime FechaPago { get; set; }

        public string DocumentoFactura { get; set; }

        public string EstadoFactura { get; set; }

    }
}
