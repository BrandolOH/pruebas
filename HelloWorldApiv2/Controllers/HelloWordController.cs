using Microsoft.AspNetCore.Mvc;

namespace HelloWorldApiv2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Hola mundo desde ASP.NET Core 🚀";
        }
    }
}
