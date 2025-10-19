using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class RamoCar
{
    public int IdRamoCar { get; set; }

    public string? UbicacionProyecto { get; set; }

    public string? TipoConstruccion { get; set; }

    public string? RutaDocumentoContrato { get; set; }

    public string? RutaDocumentoMemoria { get; set; }

    public string? RutaDocumentoPresupuesto { get; set; }

    public string? RutaDocumentoCronograma { get; set; }

    public int? FkCliente { get; set; }

    public int? FkPoliza { get; set; }
}
