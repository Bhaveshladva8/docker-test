using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace docker_test.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class NamesController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Test", "Nirav", "B", "N"
        };

        [HttpGet(Name = "GetNames")]
        public List<string> Get()
        {
            return Summaries.ToList();
        }
    }
}
