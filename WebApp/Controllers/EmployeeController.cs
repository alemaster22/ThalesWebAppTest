using BusinessComponents;
using Microsoft.AspNetCore.Mvc;
using RepositoryComponets.DTO;

namespace WebApp.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(new { data = _employeeService.GetEmployees().Result!.data });            
        }

        [HttpGet]
        public IActionResult GetById(int id)
        {
            List<EmployeeData> listaSalida = new List<EmployeeData>();
            listaSalida.Add(_employeeService.GetEmployeesById(id).Result.data);           
            return Json(new { data = listaSalida });
        }
    }     
}

