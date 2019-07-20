using DemoSolution.Infrastructure;
using System;

namespace DemoSolution
{
    public class Program
    {
        private static ClientService _clientService = new ClientService();
        private static CarService _carService = new CarService();

        public static void Main(string[] args)
        {
            int exit;
            int zmienna = 0;
            do
            {
                Console.WriteLine("MenuGłówne");
                Console.WriteLine("Podaj co chcesz zrobić wciskając odpowiedni numer:");
                Console.WriteLine("[1].Naprawa Silnika z dodatkami");
                Console.WriteLine("[2].Wyświetl Listę klientów z pliku");
                Console.WriteLine("[3].Dodaj Klientów do listy");
                Console.WriteLine("[4].Edytuj nr rejestracyjny klienta");
                Console.WriteLine("[5].Usuń klienta z listy");
                Console.WriteLine("[6].Zapisz klientów z pliku .txt w folderze na pulpicie");
                Console.WriteLine("[7].Wyświetl wszystkie samochody");
                Console.WriteLine("[8].Dodaj samochód do listy Samochodów");
                Console.WriteLine("[9].Edytuj dane samochodu z listy");
                Console.WriteLine("[10].Usuń samochód z listy samochodów");

                zmienna = Convert.ToInt32(Console.ReadLine());

                switch (zmienna)
                {
                    case 1:
                        Sprzedaz();
                        break;
                    case 2:
                        ShowClients();
                        break;
                    case 3:
                        AddClient();
                        break;
                    case 4:
                        UpdateClient();
                        break;
                    case 5:
                        DeleteClient();
                        break;
                    case 6:
                        SaveAsTXT();
                        break;
                    case 7:
                        ShowCars();
                        break;
                    case 8:
                        AddCar();
                        break;
                    case 9:
                        UpdateCar();
                        break;
                    case 10:
                        DeleteCar();
                        break;
                    default:
                        Console.WriteLine("Podano złą komendę!");
                        break;
                }
                Console.WriteLine("Jeśli chcesz wyjść wciśnie '0'. Jeśli nie, wciśnij dowolną cyfrę");
                exit = Convert.ToInt32(Console.ReadLine());
            } while (exit != 0);
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

        private static void ShowClients()
        {
            var clients = _clientService.GetClients();
            foreach (var client in clients)
            {
                Console.WriteLine($"Imię: '{client.FirstName}', nazwisko: '{client.Surname}'");
            }
        }

        private static void AddClient()
        {
            Console.WriteLine("Podaj imię Klienta");
            var firstName = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko Klienta");
            var surname = Console.ReadLine();
            Console.WriteLine("Podaj numer rejestracyjny pojazdu");
            var plataName = Console.ReadLine();

            _clientService.AddClient(firstName, surname, plataName);
        }
        
        private static void UpdateClient()
        {
            Console.WriteLine("Podaj nr ID klienta do nadpisania");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj nowy numer rejestracyjny klienta do nadpisania");
            string newNumber = Console.ReadLine();
            _clientService.UpdateClient(id, newNumber);
        }

        private static void DeleteClient()
        {
            Console.WriteLine("Podaj nr ID klienta do usunięcia");
            int id = Convert.ToInt32(Console.ReadLine());
            _clientService.DeleteClient(id);
        }

        private static void Sprzedaz()
        {
            var saleView = new SaleView();
            saleView.Sale();
        }

        private static void SaveAsTXT()
        {
            FileService.SaveAsTXT();
        }
    }
}