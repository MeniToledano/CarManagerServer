using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Cars.Models;
using Cars.Data;

namespace Cars.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : Controller
    {
        private readonly CarManagerContext _carManagerContext;

        public EmployeeController(CarManagerContext carManagerContext)
        {
            _carManagerContext = carManagerContext;
        }
        // GET: local/employee
        [HttpGet]
        public IEnumerable<Employee> GetAllEmployees()
        {
            return _carManagerContext.Employees;
        }

        // GET: local/employee/2
        [HttpGet("{id}")]
        public Employee GetEmployeeByID(int id)
        {
            return _carManagerContext.Employees.SingleOrDefault(x => x.EmployeeId == id);
        }

    }
}
