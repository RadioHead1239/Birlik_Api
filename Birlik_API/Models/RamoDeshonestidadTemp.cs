using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class RamoDeshonestidadTemp
{
    public int IdRamoDeshonestidadTemp { get; set; }

    public int Items { get; set; }

    public string? ActividadRealizar { get; set; }

    public string? UbicacionTrabajo { get; set; }

    public int NroTrabajadores { get; set; }

    public decimal SumaAsegurada { get; set; }

    public decimal Pn { get; set; }

    public decimal Pt { get; set; }

    public decimal Comision { get; set; }

    public decimal MontoComision { get; set; }

    public string? FkUsuario { get; set; }
}
