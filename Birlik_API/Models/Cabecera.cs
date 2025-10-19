using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class Cabecera
{
    public int IdCabecera { get; set; }

    public string? Imagen { get; set; }

    public string? AreaUso { get; set; }

    public string? ControladorUso { get; set; }

    public string? ActionUso { get; set; }
}
