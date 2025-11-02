using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class EstadoPuntuacion
{
    public int IdEstadoPuntuacion { get; set; }

    public string? Nombre { get; set; }

    public int? Minimo { get; set; }

    public int? Maximo { get; set; }

    public string? Descripcion { get; set; }

    public string? Color { get; set; }
}
