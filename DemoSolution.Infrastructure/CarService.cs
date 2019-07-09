using DemoSolution.Core;
using System;
using System.Collections.Generic;

namespace DemoSolution.Infrastructure
{
    public class CarService
    {
        private readonly CarRepository _carRepository = new CarRepository();

        public List<Car> GetCars()
        {
            return _carRepository.Get();
        }

        public void AddCar(string brandName, string model, int clientId)
        {
            var car = new Car();
            car.Id = Guid.NewGuid();
            car.BrandName = brandName;
            car.Model = model;
            car.ClientId = clientId;
            car.CreatedBy = Environment.UserName;
            car.CreatedAt = DateTime.UtcNow;
            _carRepository.Add(car);
        }

        public void DeleteCar(Guid id)
        {
            _carRepository.Delete(id);
        }

        public void UpdateCar(Guid id, string brandName, string model, int clientId)
        {
            _carRepository.Update(id, brandName, model, clientId);
        }
    }
}
