using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoSolution.Infrastructure;
using DemoSolution.Web.ViewModels;
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
        public IActionResult Edit(Guid id)
        {
            var carService = new CarService();
            var cars = carService.GetCars();
            var car = cars.Single(x => x.Id == id);

            var carViewModel = new CarViewModel
            {
                Id = car.Id,
                BrandName = car.BrandName,
                Model = car.Model,
                ClientId = car.ClientId
            };

            return View(carViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,BrandName,Model,ClientId")] CarViewModel car)
        {
            var carService = new CarService();
            carService.UpdateCar(car.Id, car.BrandName, car.Model, car.ClientId);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(
            [Bind("Id,BrandName,Model,ClientId")] CarViewModel car)
        {
            if (ModelState.IsValid)
            {
                var carService = new CarService();
                carService.AddCar(car.BrandName, car.Model, car.ClientId);

                return RedirectToAction("Index");
            }
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(Guid Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var carService = new CarService();
            var cars = carService.GetCars();
            var car = cars.Single(x => x.Id == Id);
            if (car == null)
            {
                return NotFound();
            }
            var carViewModel = new CarViewModel
            {
                Id = car.Id,
            };

            return View(carViewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var carService = new CarService();
            carService.DeleteCar(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int id)
        {
            var clientService = new ClientService();
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
