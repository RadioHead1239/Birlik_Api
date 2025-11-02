using System;
using System.Collections.Generic;

namespace Birlik_Api.Models;

public partial class Prima
{
    public int IdPrima { get; set; }

    public string? DocumentoPrima { get; set; }

    public string? FormaPagoPrima { get; set; }

    public decimal? SumaAsegurada { get; set; }

    public decimal? ImporteComisionBroker { get; set; }

    public decimal? ImporteComisionSubagente { get; set; }

    public decimal? PrimaComercial { get; set; }

    public decimal? PrimaNeta { get; set; }

    public decimal? PrimaTotal { get; set; }

    public decimal? TasaRiesgo { get; set; }

    public int? CantidadCuotas { get; set; }

    public decimal? ImporteCadaCuota { get; set; }

    public int? CodigoPrimeraCuota { get; set; }

    public DateOnly? VencimientoPrimeraCuota { get; set; }

    public int? FkCliente { get; set; }

    public int? FkPoliza { get; set; }

    public DateTime? FechaRegistroPrima { get; set; }

    public string? NumeroConvenio { get; set; }

    public decimal? PrimaMinima { get; set; }
}
