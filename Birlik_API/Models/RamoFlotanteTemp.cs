using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class RamoFlotanteTemp
{
    public int IdRamoFlotanteTemp { get; set; }

    public int Items { get; set; }

    public string? Asegurado { get; set; }

    public string? FechaSalidaOrigen { get; set; }

    public string? Origen { get; set; }

    public string? Destino { get; set; }

    public string? DescripcionMercaderiaTransportar { get; set; }

    public string? TipoEmbalaje { get; set; }

    public decimal Tasa { get; set; }

    public decimal Pn { get; set; }

    public decimal Pt { get; set; }

    public decimal Comision { get; set; }

    public decimal MontoComision { get; set; }

    public string? FkUsuario { get; set; }
}
