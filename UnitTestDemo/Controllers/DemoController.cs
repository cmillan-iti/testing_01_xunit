using Microsoft.AspNetCore.Mvc;

namespace UnitTestDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DemoController : ControllerBase
    {        
        private readonly ILogger<DemoController> _logger;

        public DemoController(ILogger<DemoController> logger)
        {
            _logger = logger;
        }

        [HttpGet("Suma")]
        public int Suma(int x, int y)
        {
            return x + y;
        }        
    }
}