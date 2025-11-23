using Birlik.Data;
using Birlik_Api.Models;
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

        public IEnumerable<PolizaResponseDTO> PolizasxClientexVigenciainicioFkClienteTotales(int idCliente)
        {
            using (var db = new ApplicationDbContext())
            {
                var latestPolicies = db.Poliza
                    .Where(pol => pol.Fk_Cliente == idCliente
                                  && !pol.EstadoPoliza.Contains("Inclusion"))
                    .OrderByDescending(pol => pol.VigenciaInicio)
                    .ToList();

                var query = from pol in latestPolicies
                            join pri in db.Prima
                                on pol.Id_Poliza equals pri.Fk_Poliza
                            join doc in db.Documento
                                on pol.Id_Poliza equals doc.Fk_Poliza into docGroup
                            from doc in docGroup
                                .Where(d => d.TituloDocumento.Contains("Constancia"))
                                .DefaultIfEmpty()
                            select new PolizaResponseDTO
                            {
                                Id_poliza = pol.Id_Poliza,
                                NumeroPoliza = pol.NumeroPoliza,
                                ProductoRamo = pol.ProductoRamo,
                                VigenciaInicio = pol.VigenciaInicio,
                                VigenciaFin = pol.VigenciaFin,
                                PrimaTotal = pri.PrimaTotal,
                                EsActivo = pol.VigenciaInicio <= DateTime.Now
                                           && pol.VigenciaFin >= DateTime.Now,
                                RutaDocumento = doc != null ? doc.RutaDocumento : null
                            };

                return query.ToList();
            }
        }


    }
}
