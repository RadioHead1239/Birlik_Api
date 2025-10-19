using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class Portadum
{
    public int IdPortada { get; set; }

    public string? ImagenPortada { get; set; }

    public string? TipoPortada { get; set; }

    public int? FkGlobal { get; set; }
}
