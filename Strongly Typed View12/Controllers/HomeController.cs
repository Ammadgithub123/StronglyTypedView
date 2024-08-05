using Microsoft.AspNetCore.Mvc;
using Strongly_Typed_View12.Models;
using System.Diagnostics;

namespace Strongly_Typed_View12.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //Employee az = new Employee()
            //{
            //    EmpId = 2,
            //    EmpName = "Ammad",
            //    Designation = "Naukar",
            //    Salary = 25000
            //};

            var az1 = new List<Employee>
            {
                new Employee { EmpId = 1, EmpName = "Ammad", Designation = "Naukar", Salary = 25000 },
                new Employee { EmpId = 2, EmpName = "Moiz", Designation = "SQA", Salary = 30000 },
                new Employee { EmpId = 3, EmpName = "Shan", Designation = "Asp.NET", Salary = 35000 },
                new Employee { EmpId = 4, EmpName = "Hasan", Designation = "Manager", Salary = 40000 },
            };
            return View(az1);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
