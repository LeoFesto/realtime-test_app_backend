using Microsoft.AspNetCore.Mvc;

namespace realtime_on_production_test.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        public HomeController() { }

        [HttpGet("Index")]
        public IActionResult Index()
        {
            return Ok("Ok");
        }
    }
}
