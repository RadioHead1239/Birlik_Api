using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class RamoRoboAsalto
{
    public int IdRamoRoboAsalto { get; set; }

    public int FkCliente { get; set; }

    public int FkPoliza { get; set; }

    public int Items { get; set; }

    public string? CaracteristicasRiesgo { get; set; }

    public string? GiroNegocio { get; set; }

    public string? MateriaAsegurada { get; set; }

    public decimal ValorDeclarado { get; set; }

    public decimal ValorAsegurado { get; set; }

    public int NroLocalesAsegurado { get; set; }

    public decimal Pn { get; set; }

    public decimal Pt { get; set; }

    public decimal Comision { get; set; }

    public decimal MontoComision { get; set; }
}
