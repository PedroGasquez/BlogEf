using Blog.Attributes;
using Microsoft.AspNetCore.Mvc;


// Health Check
namespace Blog.Controllers
{
    [ApiController]
    [Route("")]
    public class HomeController : ControllerBase
    {
        [HttpGet("")]
       // [ApiKey]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
