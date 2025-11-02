using Birlik_Api.Models.DTO;
using Birlik_Api.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Birlik_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmergencyController : ControllerBase
    {
        private readonly TwilioService _twilioService;

        public EmergencyController(TwilioService twilioService)
        {
            _twilioService = twilioService;
        }

        /// <summary>
        /// Envía un SMS de emergencia al número especificado.
        /// </summary>
        [HttpPost("sms")]
        public async Task<IActionResult> SendSms([FromBody] EmergencySmsDto dto)
        {
            if (dto == null || string.IsNullOrEmpty(dto.To) || string.IsNullOrEmpty(dto.Message))
                return BadRequest("El número de destino y el mensaje son obligatorios.");

            try
            {
                var sid = await _twilioService.SendSmsAsync(dto.To, dto.Message);
                return Ok(new
                {
                    Message = "📩 SMS enviado correctamente.",
                    Sid = sid
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Error = "Error al enviar SMS", Details = ex.Message });
            }
        }

        /// <summary>
        /// Realiza una llamada de emergencia al número especificado.
        /// </summary>
        [HttpPost("call")]
        public async Task<IActionResult> MakeCall([FromBody] EmergencyCallDto dto)
        {
            if (dto == null || string.IsNullOrEmpty(dto.To))
                return BadRequest("El número de destino es obligatorio.");

            try
            {
                // Puedes usar un URL propio con TwiML personalizado si lo deseas
                var url = string.IsNullOrEmpty(dto.VoiceUrl)
                    ? "http://demo.twilio.com/docs/voice.xml"
                    : dto.VoiceUrl;

                var sid = await _twilioService.MakeCallAsync(dto.To, url);

                return Ok(new
                {
                    Message = "📞 Llamada iniciada correctamente.",
                    Sid = sid
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Error = "Error al realizar la llamada", Details = ex.Message });
            }
        }
    }
}
