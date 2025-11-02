using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class Ramo
{
    public int IdRamo { get; set; }

    public string? DescripcionRamo { get; set; }

    public string? DescripcionCortoRamo { get; set; }

    public string? EstadoRamo { get; set; }
}
