using Microsoft.AspNetCore.Mvc;

namespace WebApi_Handson1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        // GET: api/values
        [HttpGet]
        public IActionResult Get()
        {
            var values = new string[] { "value1", "value2" };
            return Ok(values); // returns 200 OK with data
        }

        // POST: api/values
        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            return Ok($"Received: {value}"); // returns 200 OK with message
        }
    }
}
