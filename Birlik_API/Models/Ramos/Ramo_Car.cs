using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Birlik.Models.Entities.Ramos
{
    public class Ramo_Car
    {
        [Key]
        public int Id_Ramo_Car { get; set; }

        public string UbicacionProyecto { get; set; }

        public string TipoConstruccion { get; set; }

        public string RutaDocumento_Contrato { get; set; }

        public string RutaDocumento_Memoria { get; set; }

        public string RutaDocumento_Presupuesto { get; set; }

        public string RutaDocumento_Cronograma { get; set; }

        public int fk_cliente { get; set; }

        public int fk_poliza { get; set; }

    }
}
