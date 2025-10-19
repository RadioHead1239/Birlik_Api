using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class SeguroRpatemp
{
    public int IdSeguroRpatemp { get; set; }

    public string? NumeroPoliza { get; set; }

    public decimal? Monto { get; set; }

    public string? FechaFactura { get; set; }

    public string? TipoDocumento { get; set; }

    public string? NumeroDocumento { get; set; }

    public string? FkUsuario { get; set; }

    public int? NumeroProforma { get; set; }
}
