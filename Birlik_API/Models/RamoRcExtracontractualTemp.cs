using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class RamoRcExtracontractualTemp
{
    public int IdRamoRcExtracontractualTemp { get; set; }

    public int Items { get; set; }

    public string? DepartamentoPeru { get; set; }

    public string? UbicacionRiesgo { get; set; }

    public string? TipoTrabajo { get; set; }

    public string? DescripcionActividadProyecto { get; set; }

    public string? AseguradoAdicional { get; set; }

    public decimal MontoContratado { get; set; }

    public decimal SumaAsegurada { get; set; }

    public decimal TasaRiesgo { get; set; }

    public decimal Pn { get; set; }

    public decimal Pc { get; set; }

    public decimal Pt { get; set; }

    public decimal Comision { get; set; }

    public decimal MontoComision { get; set; }

    public string? Siniestralidad { get; set; }

    public string? FkUsuario { get; set; }
}
