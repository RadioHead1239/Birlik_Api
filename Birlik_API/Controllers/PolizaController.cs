using Birlik.Data;
using Birlik_Api.Models.DTO;
using Birlik_Api.Models.Response;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Birlik_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PolizaController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PolizaController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("cliente/{idCliente}")]
        public async Task<ActionResult<IEnumerable<PolizaResponseDTO>>>PolizasxClientexVigenciainicioFkClienteTotales(int idCliente)
        {
            try
            {
                var query =
                    from pol in _context.Poliza
                        .Where(p => p.Fk_Cliente == idCliente &&
                                    !p.EstadoPoliza.Contains("Inclusion"))

                    join comp in _context.CompaniaSeguro
                        on pol.FK_Compania equals comp.Id_CompaniaSeguro

                    join doc in _context.Documento
                        on pol.Id_Poliza equals doc.Fk_Poliza into docGroup
                    from doc in docGroup
                        .Where(d => d.TituloDocumento.Contains("Constancia"))
                        .DefaultIfEmpty()

                    orderby pol.VigenciaInicio descending

                    select new PolizaResponseDTO
                    {
                        Id_poliza = pol.Id_Poliza,
                        NumeroPoliza = pol.NumeroPoliza,
                        ProductoRamo = pol.ProductoRamo, //Ramo compañia
                        VigenciaInicio = pol.VigenciaInicio,
                        VigenciaFin = pol.VigenciaFin,
                        NombreCompaniaSeguro = comp.NombreCompaniaSeguro,
                        EsActivo = pol.VigenciaInicio <= DateTime.Now
                                   && pol.VigenciaFin >= DateTime.Now,
                        RutaDocumento = doc != null ? doc.RutaDocumento : null
                    };

                var result = await query.ToListAsync();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error en servidor: {ex.Message}");
            }
        }

    }
}
