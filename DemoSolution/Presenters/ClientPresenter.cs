using DemoSolution.Infrastructure;
using System;

namespace DemoSolution
{
    public class ClientPresenter
    {
        private static ClientService _clientService = new ClientService();

        public static void ShowMenuClient()
        {
            Console.WriteLine("[1].Wyświetl Listę klientów z pliku");
            Console.WriteLine("[2].Dodaj Klientów do listy");
            Console.WriteLine("[3].Edytuj nr rejestracyjny klienta");
            Console.WriteLine("[4].Usuń klienta z listy");
            Console.WriteLine("[5].Pokaż jednego klienta");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    ShowClients();
                    break;
                case 2:
                    AddClient();
                    break;
                case 3:
                    UpdateClient();
                    break;
                case 4:
                    DeleteClient();
                    break;
                case 5:
                    ShowOneClient();
                    break;
                default:
                    MainPresenter.ShowMenu();
                    break;
            }
        }

        private static void ShowOneClient()
        {
            Console.WriteLine("Podaj id");
            int id = Convert.ToInt32(Console.ReadLine());

            var client = _clientService.ShowOneClient(id);

            Console.WriteLine($"Imię: '{client.FirstName}', nazwisko: '{client.Surname}'");
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
    }
}