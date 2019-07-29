using DemoSolution.Infrastructure;
using System;


namespace DemoSolution
{
    public class CarPresenter
    {
        private static CarService _carService = new CarService();
        
        public static void ShowMenuCars()
        {
            Console.WriteLine("[1].Wyświetl wszystkie samochody");
            Console.WriteLine("[2].Dodaj samochód do listy Samochodów");
            Console.WriteLine("[3].Edytuj dane samochodu z listy");
            Console.WriteLine("[4].Usuń samochód z listy samochodów");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    ShowCars();
                    break;
                case 2:
                    AddCar();
                    break;
                case 3:
                    UpdateCar();
                    break;
                case 4:
                    DeleteCar();
                    break;
                case 5:
                    ShowCarsFromOne();
                    break;
                default:
                    MainPresenter.ShowMenu();
                    break;
            }
        }

        private static void ShowCarsFromOne()
        {
            Console.WriteLine("Podaj id klienta");
            int id = Convert.ToInt32(Console.ReadLine());
            var cars = _carService.GetCars();
            _carService.ShowCarsFromOne(id);
            foreach (var car in cars)
            {
                Console.WriteLine($"ID: {car.Id}, marka: '{car.BrandName}', model: '{car.Model}', klient: {car.ClientId}");
            }
        }

        private static void ShowCars()
        {
            var cars = _carService.GetCars();
            foreach (var car in cars)
            {
                Console.WriteLine($"ID: {car.Id}, marka: '{car.BrandName}', model: '{car.Model}', klient: {car.ClientId}");
            }
        }

        private static void AddCar()
        {
            Console.WriteLine("Podaj markę samochodu");
            var brandName = Console.ReadLine();
            Console.WriteLine("Podaj model samochodu");
            var model = Console.ReadLine();
            Console.WriteLine("Podaj ID klienta");
            int clientId = Convert.ToInt32(Console.ReadLine());
            _carService.AddCar(brandName, model, clientId);
        }

        private static void UpdateCar()
        {
            ShowCars();

            Console.WriteLine("Podaj nr ID klienta do nadpisania");
            var id = Guid.Parse(Console.ReadLine());
            Console.WriteLine("Podaj nową markę do nadpisania");
            string brandName = Console.ReadLine();
            Console.WriteLine("Podaj nowy model do nadpisania");
            string model = Console.ReadLine();
            Console.WriteLine("Podaj nowe Id klienta");
            int clientId = Convert.ToInt32(Console.ReadLine());

            _carService.UpdateCar(id, brandName, model, clientId);
        }

        private static void DeleteCar()
        {
            ShowCars();

            Console.WriteLine("Podaj nr ID klienta do usunięcia");
            var id = Guid.Parse(Console.ReadLine());
            _carService.DeleteCar(id);
        }
    }
}