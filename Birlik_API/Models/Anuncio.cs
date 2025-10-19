using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class Anuncio
{
    public int IdAnuncio { get; set; }

    public string? TipoAnuncio { get; set; }

    public string? CuerpoAnuncio { get; set; }

    public string? AsuntoAnuncio { get; set; }

    public string? Destinatarios { get; set; }

    public DateTime FechaRegistro { get; set; }

    public int? CantidadVeces { get; set; }

    public int? RealizadasVeces { get; set; }
}
