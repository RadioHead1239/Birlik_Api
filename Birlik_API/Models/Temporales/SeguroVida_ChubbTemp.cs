using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Birlik.Models.Entities.Temporales
{
    [Table("SeguroVida_ChubbTemp")]
    public class SeguroVida_ChubbTemp
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int Id_SeguroVidaTemp { get; set; }

        public string Movimiento { get; set; }
        public string ApePaterno { get; set; }
        public string ApeMaterno { get; set; }
        public string PNombre { get; set; }
        public string SNombre { get; set; }
        public string TipoDoc { get; set; }
        public string NroDoc { get; set; }
        public string Genero { get; set; }
        public string FecNac { get; set; }
        public decimal Remuneracion { get; set; }
        public string fk_usuario { get; set; }
        public int Item { get; set; }
    }
}
