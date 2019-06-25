using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using DemoSolution.Core;

namespace DemoSolution.Infrastructure
{
    public class ClientService
    {
        private readonly ClientRepository _clientRepository = new ClientRepository();
        private List<string> klienci = new List<string>()
        {
            "Jon Smith, nr rejestracyjny: SMI XXXX, Data: 21.06.2019",
            "Donal Trump, nr rejestracyjny: SMI YYYY, Data: 21.06.2019",
        };
        private string imie;
        private string nazwisko;
        private string rejestracjaSamochodu;

        public void DodajKlienta(string klient)
        {
            Console.WriteLine(" Podaj Imię klienta");
            imie = Console.ReadLine();
            Console.WriteLine(" Podaj Nazwisko klienta");
            nazwisko = Console.ReadLine();
            Console.WriteLine(" Podaj numer rejestracyjny pojazdu klienta");
            rejestracjaSamochodu = Console.ReadLine();
            
            klienci.Add(klient);
        }

        public void DeleteClient(int id)
        {
            _clientRepository.Delete(id);
        }

        public List<Client> GetClients()
        {    
            return _clientRepository.Get();
        }

        public void AddClient(string userName, string firstName, string surname, string plataName)
        {
            var client = new Client();
            client.FirstName = firstName;
            client.Surname = surname;
            client.PlateName = plataName;
            client.CreatedBy = Environment.UserName;
            client.CreatedAt = DateTime.UtcNow;
            _clientRepository.Add(client);
        }

        public void UpdateClient(int id, string newNumber)
        {
            _clientRepository.Update(id, newNumber);
        }
    }
}