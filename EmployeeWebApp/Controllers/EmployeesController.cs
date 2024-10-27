using EmployeeWebApp.Services;
using EmployeeWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeWebApp.Controllers
{
    public class EmployeesController : Controller
    {
        private EmployeeService _employeeService;
        public EmployeesController(EmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        [Route("~/Employees")]
        public IActionResult Employees()
        {
            var employeeViewModel = new EmployeeViewModel
            {
                Employees = _employeeService.GetEmployees().Select(employee => 
                new EmployeeModel
                {
                    Id = employee.Id,
                    Name = employee.Name,
                    Designation = employee.Designation,
                    Email = employee.Email
                }).ToList()
            };

            return View("Employees", employeeViewModel);
        }
    }
}
