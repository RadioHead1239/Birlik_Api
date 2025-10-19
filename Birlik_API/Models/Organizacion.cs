using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class Organizacion
{
    public int IdOrganizacion { get; set; }

    public string? MetodoTrabajo { get; set; }

    public string? Direccion { get; set; }

    public string? NumTelefonico { get; set; }

    public DateOnly? FechaInscripcion { get; set; }

    public string? ImgOrganizacion { get; set; }

    public string? NomOrganizacion { get; set; }

    public string? CorreoCobranza { get; set; }

    public string? CorreosCopia { get; set; }
}
