using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class PrimaMinima
{
    public int IdPrimaMinima { get; set; }

    public string? PrimaMinimaEmision { get; set; }

    public string? PrimaMinimaRenovacion { get; set; }

    public string? PrimaMinimaInclusion { get; set; }

    public int? FkCompaniaSeguro { get; set; }
}
