using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class RamoViajero
{
    public int IdRamoViajero { get; set; }

    public int FkCliente { get; set; }

    public int FkPoliza { get; set; }

    public int Items { get; set; }

    public string? TipoPlan { get; set; }

    public string? Origen { get; set; }

    public string? Destino { get; set; }

    public string? ContactoEmergencia { get; set; }

    public decimal Pn { get; set; }

    public decimal Pt { get; set; }

    public decimal Comision { get; set; }

    public decimal MontoComision { get; set; }
}
