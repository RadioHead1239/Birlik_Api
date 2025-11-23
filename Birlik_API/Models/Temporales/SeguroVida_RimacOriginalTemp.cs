using System.ComponentModel.DataAnnotations;

namespace Birlik.Models.Entities.Temporales
{
    public class SeguroVida_RimacOriginalTemp
    {
        [Key]
        public int Id_SeguroVida_RimacOriginalTemp { get; set; }

        public string TipoDoc { get; set; }

        public string NroDoc { get; set; }

        public string Tipo_Producto { get; set; }

        public string Sucursal_Empresa { get; set; }

        public string Paterno { get; set; }

        public string Materno { get; set; }

        public string Nombre1 { get; set; }

        public string Nombre2 { get; set; }

        [DataType(DataType.Date)]// Me va a traer solo la fecha mas no la hora
        public DateTime FechaNac { get; set; }

        public string Sexo { get; set; }

        public decimal Remuneracion { get; set; }

        public string Tipo_Trabajador { get; set; }

        public string fk_usuario { get; set; }

        public int Item { get; set; }

    }
}
