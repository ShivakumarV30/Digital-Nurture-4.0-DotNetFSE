using Microsoft.AspNetCore.Mvc;

namespace WebApi_Exercise2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        static List<string> employees = new List<string>() { "Ram", "Sam", "Kumar" };

        // ✅ GET: api/Employee
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(employees);
        }

        // ✅ POST: api/Employee
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public ActionResult Post([FromBody] string employeeName)
        {
            employees.Add(employeeName);
            return Created("", employeeName);
        }
    }
}
