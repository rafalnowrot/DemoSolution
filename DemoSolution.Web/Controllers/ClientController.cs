using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoSolution.Infrastructure;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoSolution.Web.Controllers
{
    public class ClientController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var clientService = new ClientService();
            var clients = clientService.GetClients();

            return View(clients);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
