using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class Automatizacion
{
    public int IdAutomatizacion { get; set; }

    public string? TipoAutomatizacion { get; set; }

    public string? EstadoAutomatizacion { get; set; }

    public string? Asunto { get; set; }

    public string? ConCopia { get; set; }

    public string? CorreoEmisor { get; set; }

    public string? DescripcionAutomatizacion { get; set; }

    public string? ObservacionAutomatizacion { get; set; }

    public string? CabeceraUrl { get; set; }

    public string? FirmaCorreo { get; set; }
}
