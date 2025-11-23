using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Birlik.Models.Entities
{
    public class SubAgente
    {
        [Key]
        public int Id_SubAgente { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string DescripcionSubAgente { get; set; }
    }
}
