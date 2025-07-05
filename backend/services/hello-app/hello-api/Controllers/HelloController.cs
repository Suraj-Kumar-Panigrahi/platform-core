using Microsoft.AspNetCore.Mvc;



namespace HelloApi.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello, from platform core!");
        }

        [HttpGet("health")]
        public IActionResult Health()
        {
            return Ok("Healthy");
        }
    }
}
