using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities
{
    public class Prima
    {
        [Key]
        public int Id_Prima { get; set; }

        public string DocumentoPrima { get; set; }

        public string FormaPagoPrima { get; set; }

        public decimal SumaAsegurada { get; set; }

        public decimal ImporteComisionBroker { get; set; }

        public decimal ImporteComisionSubagente { get; set; }

        public decimal PrimaComercial { get; set; }

        public decimal PrimaNeta { get; set; }

        public decimal PrimaTotal { get; set; }

        public decimal TasaRiesgo { get; set; }

        public int Cantidad_Cuotas { get; set; }

        public decimal ImporteCadaCuota { get; set; }

        public int CodigoPrimeraCuota { get; set; }


        [DataType(DataType.Date)]// Me va a traer solo la fecha mas no la hora
        public DateTime VencimientoPrimeraCuota { get; set; }

        public int Fk_Cliente { get; set; }

        public int Fk_Poliza { get; set; }

        public DateTime FechaRegistroPrima { get; set; }

        public string NumeroConvenio { get; set; }


        public decimal? PrimaMinima { get; set; }




    }
}
