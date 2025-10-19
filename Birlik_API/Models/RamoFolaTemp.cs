using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class RamoFolaTemp
{
    public int IdRamoFolaTemp { get; set; }

    public int Items { get; set; }

    public string? TipoTrabajoPracticante { get; set; }

    public string? Profesion { get; set; }

    public decimal SueldoPracticante { get; set; }

    public string? Plan { get; set; }

    public decimal Pn { get; set; }

    public decimal Pt { get; set; }

    public decimal Comision { get; set; }

    public decimal MontoComision { get; set; }

    public string? FkUsuario { get; set; }
}
