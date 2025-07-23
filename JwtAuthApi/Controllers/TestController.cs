using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuthApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        // ✅ Requires a valid token now
        [HttpGet("ping")]
        [Authorize]
        public IActionResult Ping()
        {
            return Ok("✅ Pong! You are authorized.");
        }
    }
}
