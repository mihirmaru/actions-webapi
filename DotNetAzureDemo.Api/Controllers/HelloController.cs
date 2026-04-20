using Microsoft.AspNetCore.Mvc;

namespace DotNetAzureDemo.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("API is Working from Azure 🚀");
        }
    }
}