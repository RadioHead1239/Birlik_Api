using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class Personalizado
{
    public int IdPersonalizado { get; set; }

    public string TipoPersonalizado { get; set; } = null!;

    public string? CuerpoMensaje { get; set; }

    public string? ImagenMensaje { get; set; }

    public DateTime FechaRegistro { get; set; }

    public string? AsuntoMensaje { get; set; }
}
