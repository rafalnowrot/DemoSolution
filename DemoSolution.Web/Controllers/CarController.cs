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

        // POST: Movies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,BrandName,Model,ClientId")] CarViewModel car)
        {
            var carService = new CarService();
            carService.UpdateCar(car.Id, car.BrandName, car.Model, car.ClientId);
            return RedirectToAction(nameof(Index));
        }

        // GET: Movies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Movies/Create
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
            //return View();
        }

        // GET: Movies/Delete/5
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

            //return View(clients);
        }

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var carService = new CarService();
            carService.DeleteCar(id);
            return RedirectToAction(nameof(Index));
        }

        // GET: Movies/Details/5
        public IActionResult Details(int id)
        {
            var clientService = new ClientService();
            var client = clientService.ShowOneClient(id);
            var carService = new CarService();
            var cars = carService.ShowCarsFromOne(id);
            //ViewData["Client"] = clients;
            //ViewData["Cars"] = cars;

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
                PlateName = client.PlateName,
                Cars = carViewModels
            };

            return View(clientDetailsViewModel);
        }
    }
}
