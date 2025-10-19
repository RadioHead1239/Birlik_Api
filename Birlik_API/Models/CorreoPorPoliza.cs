using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class CorreoPorPoliza
{
    public int IdCorreoPoliza { get; set; }

    public string? EmailAdicional { get; set; }

    public int? FkPoliza { get; set; }

    public string? TipoCorreoPorPoliza { get; set; }
}
