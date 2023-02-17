using Employee_Assign1.Models;
using Employee_Assign1.Repository.Interface;
using Employee_Assign1.Shared;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;

namespace Employee_Assign1.Controllers
{
   // [Route("[controller]")]
    public class EmployeeController : Controller
    {
        public readonly IPEmployee _pEmployee;
        public readonly ITEmployee _tEmployee;
		public readonly DBApplicationContext _dBApplicationContext1;

		public EmployeeController(IPEmployee pEmployee,ITEmployee tEmployee, DBApplicationContext dBApplicationContext)
        {
            _pEmployee = pEmployee;
            _tEmployee = tEmployee;
            _dBApplicationContext1 = dBApplicationContext;
        }
        [HttpGet]
       // [Route("AddEmp")]
        public IActionResult AddEmp()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddEmp(Employee employee) 
        {
            if (employee.type == 0)
            {
                _pEmployee.AddEmployee(employee);
            }
            else
            {
                _tEmployee.AddEmployee(employee);
            }
           return RedirectToAction("Index");
        }

		[HttpGet]
		public IActionResult Index()
		{
            var employee= _dBApplicationContext1.employees.ToList();
			return View(employee);
		}

		[HttpGet]
        public IActionResult Details()
        { 
            return View();
        }

        [HttpPost]
        public IActionResult Details(int enterid)
        {
            Console.WriteLine(enterid);
            Employee emp = _pEmployee.GetEmployee(enterid);
            return View(emp);
        }

        [HttpGet]
        [Route("phone/{id:int}")]
        public IActionResult PhoneNum(int id)
        {
            var emp = _pEmployee.GetEmployeePhoneNumber(id);
            return Ok(emp);
        }

    }
}
