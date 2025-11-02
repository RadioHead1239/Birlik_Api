using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class Producto
{
    public int IdProducto { get; set; }

    public string? DescripcionProducto { get; set; }

    public string? DescripcionCortoProducto { get; set; }

    public DateTime? FechaCreacion { get; set; }
}
