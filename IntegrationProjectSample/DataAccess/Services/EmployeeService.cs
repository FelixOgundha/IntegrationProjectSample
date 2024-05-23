using IntegrationProjectSample.BusinessLogic.Repository;
using IntegrationProjectSample.DataAccess.Data;
using IntegrationProjectSample.DataAccess.Entities;

namespace IntegrationProjectSample.DataAccess.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly DataDbContext _context;

        public EmployeeService(DataDbContext context)
        {
            _context = context;
        }
        public bool AddEmployee(string name, string email)
        {

            Employee employee = new Employee()
            {
                Id = Guid.NewGuid(),
                EmailAddress = email,
                Name = name,
            };

            _context.Employees.Add(employee);
            _context.SaveChanges();

            return true;
            
        }

        public List<Employee> GetEmployees()
        {
            return _context.Employees.ToList();
        }
    }
}
