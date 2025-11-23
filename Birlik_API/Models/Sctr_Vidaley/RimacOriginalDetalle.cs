using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities.Sctr_Vidaley
{
    public class RimacOriginalDetalle
    {

        [Key]
        public int Id_RimacOriginalDetalle { get; set; }

        public string TipoDoc { get; set; }

        public string Producto { get; set; }

        public string Sede { get; set; }

        public string NroDoc { get; set; }

        public string Paterno { get; set; }

        public string Materno { get; set; }

        public string Nombre1 { get; set; }

        public string Nombre2 { get; set; }

        public string FechaNac { get; set; }

        public string Sexo { get; set; }

        public decimal Remuneracion { get; set; }

        public string TipoTrabajador { get; set; }

        public int Fk_SeguroResumen { get; set; }

        public int fk_cliente { get; set; }

        public int fk_poliza { get; set; }

    }
}
