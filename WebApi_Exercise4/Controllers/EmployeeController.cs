using Microsoft.AspNetCore.Mvc;
using WebApi_Exercise4;  // ✅ Adjust if needed

namespace WebApi_Exercise4.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> employeeList = new List<Employee>
        {
            new Employee { Id = 1, Name = "John", Department = "IT", Salary = 60000 },
            new Employee { Id = 2, Name = "Jane", Department = "HR", Salary = 55000 },
            new Employee { Id = 3, Name = "Alice", Department = "Finance", Salary = 52000 }
        };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(employeeList);
        }

        [HttpPost]
        public IActionResult Post([FromBody] List<Employee> employees)
        {
            if (employees == null || employees.Count == 0)
                return BadRequest("No employee data provided");

            foreach (var emp in employees)
            {
                employeeList.Add(emp);
            }

            return Ok("Employees added successfully!");
        }
    }
}
