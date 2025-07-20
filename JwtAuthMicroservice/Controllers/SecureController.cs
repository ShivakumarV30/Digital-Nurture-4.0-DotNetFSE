using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuthDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SecureController : ControllerBase
    {
        [HttpGet("data")]
        [Authorize] // This ensures only authenticated users can access
        public IActionResult GetSecureData()
        {
            return Ok("This is protected data.");
        }
    }
}
