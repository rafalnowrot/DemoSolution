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
    }
}
