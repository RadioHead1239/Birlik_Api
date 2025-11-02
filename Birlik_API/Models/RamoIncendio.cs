using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class RamoIncendio
{
    public int IdRamoIncendio { get; set; }

    public int FkCliente { get; set; }

    public int FkPoliza { get; set; }
}
