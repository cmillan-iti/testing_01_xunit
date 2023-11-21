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

        public void Division(int v1, int v2)
        {
            var result = v1 / v2;
        }

        [HttpGet("Suma")]
        public int Suma(int x, int y)
        {
            return x + y;
        }        
    }
}