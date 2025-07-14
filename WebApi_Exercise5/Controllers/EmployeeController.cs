using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuthAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult GetEmployees()
        {
            var employees = new[] {
                new { Id = 1, Name = "Alice" },
                new { Id = 2, Name = "Bob" }
            };

            return Ok(employees);
        }
    }
}
