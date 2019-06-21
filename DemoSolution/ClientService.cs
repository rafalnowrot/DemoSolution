﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace DemoSolution
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
    }
}