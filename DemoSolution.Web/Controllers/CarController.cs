using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoSolution.Infrastructure;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoSolution.Web.Controllers
{
    public class CarController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var carService = new CarService();
            var cars = carService.GetCars();

            return View(cars);
        }
    }
}
