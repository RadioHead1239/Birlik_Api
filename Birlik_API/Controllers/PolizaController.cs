using Birlik_Api.Data;
using Birlik_Api.Models.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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





        [HttpGet]
        public IActionResult GetPolizas()
        {
            var polizas = _context.Polizas.ToList();
            return Ok(polizas);
        }
    }
}
