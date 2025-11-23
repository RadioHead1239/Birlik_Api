using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Birlik.Models.Entities
{
    public class GrupoEconomico
    {
        [Key]
        public int Id_GrupoEconomico { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string DescripcionGrupoEconomico { get; set; }
    }
}
