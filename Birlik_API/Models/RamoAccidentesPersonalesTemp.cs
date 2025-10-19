using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class RamoAccidentesPersonalesTemp
{
    public int IdRamoAccidentesPersonalesTemp { get; set; }

    public int Items { get; set; }

    public string? GiroNegocio { get; set; }

    public string? UbicacionRiesgo { get; set; }

    public string? NroTrabajadores { get; set; }

    public decimal SumaAsegurada { get; set; }

    public decimal Pn { get; set; }

    public decimal Pt { get; set; }

    public decimal Comision { get; set; }

    public decimal MontoComision { get; set; }

    public string? FkUsuario { get; set; }
}
