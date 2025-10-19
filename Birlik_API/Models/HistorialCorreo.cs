using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class HistorialCorreo
{
    public int Id { get; set; }

    public string? Asunto { get; set; }

    public DateTime? FechaRecibido { get; set; }

    public string? CuerpoMensaje { get; set; }

    public string? Sentimiento { get; set; }

    public double? Positive { get; set; }

    public double? Neutral { get; set; }

    public double? Negative { get; set; }

    public string? Resumen { get; set; }

    public string? FrasesClave { get; set; }

    public string? IdMicrosoftGraph { get; set; }

    public string? CorreoEjecutivo { get; set; }

    public string? CorreoRemitente { get; set; }

    public string? TipoBandeja { get; set; }

    public string? CorreoDestinatario { get; set; }

    public virtual ICollection<Adjunto> Adjuntos { get; set; } = new List<Adjunto>();
}
