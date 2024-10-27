using EmployeeWebApi.ApiModels;
using EmployeeWebApp.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData.EFDAL.Controllers
{
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        EmployeeService _employeeService;

        public EmployeesController(EmployeeService employeeService) {
            _employeeService = employeeService;        
        }

        [HttpPost]
        [Route("~/api/v1/employees")]
        public IActionResult AddEmployee(EmployeeAddRequest request)
        {
            var employee = new Employee
            {
                Name = request.Name,
                Designation = request.Designation,
                Email = request.Email
            };

            _employeeService.AddEmployee(employee);

            return Ok();
        }
    }
}
