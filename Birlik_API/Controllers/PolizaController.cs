using Birlik_Api.Data;
using Birlik_Api.Models;
using Birlik_Api.Models.Response;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Birlik_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PolizaController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PolizaController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("cliente/{idCliente}")]

        public async Task<IActionResult> ObtenerPolizasConConstanciasAsync(int idCliente)
        {
            var poliza = await (from p in _context.Polizas
                                join r in _context.Ramos on p.FkRamo equals r.IdRamo into ramas
                                from ramo in ramas.DefaultIfEmpty()
                                join c in _context.CompaniaSeguros on p.FkCompania equals c.IdCompaniaSeguro into cias
                                from comp in cias.DefaultIfEmpty()
                                join d in _context.Documentos
                                    on p.IdPoliza equals d.FkPoliza
                                where p.FkCliente == idCliente
                                      && EF.Functions.Like(d.TituloDocumento, "%Constancia%")
                                orderby d.FechaCreacion descending
                                select new PolizaResponseDTO
                                {
                                    IdPoliza = p.IdPoliza,
                                    NumeroPoliza = p.NumeroPoliza,
                                    NombreRamo = ramo.DescripcionRamo,
                                    NombreCompania = comp.NombreCompaniaSeguro,
                                    VigenciaInicio = p.VigenciaInicio,
                                    VigenciaFin = p.VigenciaFin,
                                    Constancia = new ConstanciaDTO
                                    {
                                        TituloDocumento = d.TituloDocumento,
                                        RutaDocumento = d.RutaDocumento
                                    }
                                })
                           .FirstOrDefaultAsync();

            return Ok(poliza);

        }

    }
}
