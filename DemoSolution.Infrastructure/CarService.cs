using DemoSolution.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoSolution.Infrastructure
{
    public class CarService
    {
        private readonly CarRepository _carRepository = new CarRepository();

        public List<Car> GetCars()
        {
            return _carRepository.Get();
        }

        public void AddClient(string brandName, string model, int clientId)
        {
            var car = new Car();
            car.BrandName = brandName;
            car.Model = model;
            car.ClientId = clientId;
            car.CreatedBy = Environment.UserName;
            car.CreatedAt = DateTime.UtcNow;
            _carRepository.Add(car);
        }

        public void DeleteCar(int id)
        {
            _carRepository.Delete(id);
        }

        public void UpdateCar(int id, string brandName, string model, int clientId)
        {
            _carRepository.Update(id, brandName, model, clientId);
        }
    }
}
