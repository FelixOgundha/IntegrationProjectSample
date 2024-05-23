using IntegrationProjectSample.DataAccess.Entities;

namespace IntegrationProjectSample.BusinessLogic.Repository
{
    public interface IEmployeeService
    {
        public bool AddEmployee(string name, string email);
        public List<Employee> GetEmployees();
    }
}
