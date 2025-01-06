using Microsoft.AspNetCore.Mvc;

namespace EventManager.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Evento 1";
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return $"Evento {id}";
        }
    }
}
