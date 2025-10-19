using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class RamoTransporte
{
    public int IdRamoTransporte { get; set; }

    public int FkCliente { get; set; }

    public int FkPoliza { get; set; }

    public int Items { get; set; }

    public string? RadioAccion { get; set; }

    public string? TipoMercaderia { get; set; }

    public string? Lme { get; set; }

    public string? Lea { get; set; }

    public decimal SumaAsegurada { get; set; }

    public decimal TasaRiesgo { get; set; }

    public decimal Pn { get; set; }

    public decimal Pt { get; set; }

    public decimal Comision { get; set; }

    public decimal MontoComision { get; set; }
}
