using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hl7SampleApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Hl7Controller : ControllerBase
    {
        private readonly ILogger<Hl7Controller> _logger;

        public Hl7Controller(ILogger<Hl7Controller> logger)
        {
            _logger = logger;
        }

        [HttpPost(Name = "SendAppointment")]
        public async Task<IActionResult> SendAppointment()
        {
            var a = 1; 
            
            if (a == 1)
                return NotFound(); 
            
            await Task.CompletedTask;

            return Ok("some response..."); 
        }
    }
}
