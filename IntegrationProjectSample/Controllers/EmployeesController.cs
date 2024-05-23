using IntegrationProjectSample.BusinessLogic.Repository;
using IntegrationProjectSample.DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IntegrationProjectSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService _employees;

        public EmployeesController(IEmployeeService employees)
        {
            _employees = employees;
        }
        // GET: api/<EmployeesController>
        [HttpGet]
        public ActionResult<List<Employee>> Get()
        {
            var result = _employees.GetEmployees();
            return Ok(result);
        }

        // POST api/<EmployeesController>
        [HttpPost]
        public ActionResult Post(string Name,string EmailAddress)
        {
            var result = _employees.AddEmployee(Name, EmailAddress);

            if (result is true) {
                return Ok(new { Status = "Success", Message = "Employees Added Successfully" });
            } 

            return BadRequest(new {Status="Failure", Message="Failed Adding Employee"});
        }

        // GET api/<EmployeesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        

        // PUT api/<EmployeesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<EmployeesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
