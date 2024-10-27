using EmployeeData.EFDAL;

namespace EmployeeWebApp.Services
{
    public class EmployeeService
    {
        private CompanyDbContext _dbContext;

        public EmployeeService(CompanyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Employee> GetEmployees()
        {
            return _dbContext.Employees.ToList();
        }

        public void AddEmployee(Employee employee)
        {
            _dbContext.Employees.Add(employee);
            _dbContext.SaveChanges();
        }
    }
}
