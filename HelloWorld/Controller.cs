using Microsoft.AspNetCore.Mvc;

namespace HelloWorld
{
    [ApiController]
    public class Controller : ControllerBase
    {
        [HttpGet("/")]
        public ActionResult<string> GetHelloDefault()
        {
            return "Hello guest";
        }

        [HttpPost("/")]
        public ActionResult<string> PostHello(NameDto dto)
        {
            return $"Hello {dto.Name}";
        }
    }
}
