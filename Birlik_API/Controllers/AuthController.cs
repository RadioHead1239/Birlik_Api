using Birlik_Api.Models.DTO;
using Birlik_API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Birlik_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AuthController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginDto dto)
        {
            if (string.IsNullOrWhiteSpace(dto.Usuario) || string.IsNullOrWhiteSpace(dto.PasswordHash))
                return BadRequest(new { message = "Debe ingresar usuario y contraseña" });

            var user = _context.Logins
                .FirstOrDefault(u => u.Usuario == dto.Usuario && u.PasswordHash == dto.PasswordHash);

            if (user == null)
                return Unauthorized(new { message = "Usuario o contraseña incorrectos" });

            return Ok(new
            {
                message = "Inicio de sesión exitoso",
                usuario = new
                {
                    usuario = user.Usuario,
                    rol = user.Rol
                }
            });
        }
    }
}
