using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class RamoHogar
{
    public int IdRamoHogar { get; set; }

    public int FkCliente { get; set; }

    public int FkPoliza { get; set; }

    public int Items { get; set; }

    public string? MateriaAsegurada { get; set; }

    public string? Direccion { get; set; }

    public int NumeroPisos { get; set; }

    public int NumeroSotanos { get; set; }

    public int AnioConstruccion { get; set; }

    public string? UsoInmueble { get; set; }

    public decimal SumaAseguradaInmueble { get; set; }

    public decimal Pn { get; set; }

    public decimal Pt { get; set; }

    public decimal Comision { get; set; }

    public decimal MontoComision { get; set; }
}
