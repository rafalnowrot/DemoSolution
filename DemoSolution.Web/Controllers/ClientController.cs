using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoSolution.Infrastructure;
using DemoSolution.Web.ViewModel;
using DemoSolution.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoSolution.Web.Controllers
{
    public class ClientController : Controller
    {
        ClientService clientService = new ClientService();

        public IActionResult Index()
        {
            var clients = clientService.GetClients();

            // TODO Zmapować listę Client na listę ClientViewModel

            return View(clients);
        }

        public IActionResult Edit(int id)
        {
            var client = clientService.GetClient(id);

            var clientViewModel = new ClientViewModel
            {
                Id = client.Id,
                FirstName = client.FirstName,
                Surname = client.Surname
            };

            return View(clientViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,Surname")] ClientViewModel client)
        {
            clientService.UpdateClient(id, client.FirstName, client.Surname);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(
            [Bind("Id,FirstName,Surname")] ClientViewModel client)
        {
            if (ModelState.IsValid)
            {
                clientService.AddClient(client.FirstName, client.Surname);
                
                return RedirectToAction("Index");
            }

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var client = clientService.GetClient(id);
            if (client == null)
            {
                return NotFound();
            }

            var clientViewModel = new ClientViewModel
            {
                Id = client.Id,
                FirstName = client.FirstName,
                Surname = client.Surname
            };

            return View(clientViewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            clientService.DeleteClient(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int id)
        {
            var client = clientService.GetClient(id);
            var carService = new CarService();
            var cars = carService.ShowCarsFromOne(id);

            var carViewModels = new List<CarViewModel>();
            foreach (var car in cars)
            {
                var carViewModel = new CarViewModel
                {
                    Id = car.Id,
                    BrandName = car.BrandName,
                    Model = car.Model,
                    ClientId = car.ClientId
                };

                carViewModels.Add(carViewModel);
            }

            var clientDetailsViewModel = new ClientDetailsViewModel
            {
                Id = client.Id,
                FirstName = client.FirstName,
                Surname = client.Surname,
                Cars = carViewModels
            };

            return View(clientDetailsViewModel);
        }
    }
}
