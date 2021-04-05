using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Softplan.Service.Dtos;
using Softplan.Service.Interfaces;

namespace Softplan.Api2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculajurosController : ControllerBase
    {
        private readonly ILogger<CalculajurosController> _logger;

        private readonly ISoftplanService _service;

        public CalculajurosController(ILogger<CalculajurosController> logger, ISoftplanService service)
        {
            _logger = logger;
            _service = service;
        }

        // http://localhost:36831/calculajuros?valorinicial=100&tempo=5
        [HttpGet]
        public CalculaJurosDto Get(decimal valorinicial, int tempo)
        {
            var service = _service.CalculaJuros(valorinicial, tempo);
            return service;
        }
    }
}
