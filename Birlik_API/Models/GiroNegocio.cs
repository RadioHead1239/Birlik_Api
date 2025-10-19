using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class GiroNegocio
{
    public int IdGiroNegocio { get; set; }

    public string? CodigoGiro { get; set; }

    public string? EstadoGiro { get; set; }

    public string? DescripcionGiroNegocio { get; set; }
}
