using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class RamoRcProfesional
{
    public int IdRamoRcProfesional { get; set; }

    public int FkCliente { get; set; }

    public int FkPoliza { get; set; }

    public int Items { get; set; }

    public string? CaracteristicasRiesgo { get; set; }

    public string? Ubicacion { get; set; }

    public string? GiroNegocio { get; set; }

    public decimal ValorAsegurado { get; set; }

    public decimal SumaAsegurada { get; set; }

    public decimal TasaRiesgo { get; set; }

    public decimal Pn { get; set; }

    public decimal Pt { get; set; }

    public decimal Comision { get; set; }

    public decimal MontoComision { get; set; }
}
