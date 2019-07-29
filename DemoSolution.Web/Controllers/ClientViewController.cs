using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoSolution.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace DemoSolution.Web.Controllers
{
    public class ClientViewController : Controller
    {
        // GET: Movies/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var clientService = new ClientService();
            var clients = clientService.ShowOneClient(id);
            var carService = new CarService();
            var cars = carService.ShowCarsFromOne(id);
            ViewData["Client"] = clients;
            ViewData["Cars"] = cars;
            return View();
        }
    }
}