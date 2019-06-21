using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace DemoSolution
{
    public class ClientService
    {
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

            klient = imie + " " + nazwisko + ", nr rejestracyjny:" + rejestracjaSamochodu + ", Data: " + DateTime.Now;
            klienci.Add(klient);
        }

        public void UsunKlienta(string klient)
        {
            klienci.Remove(klient);
        }

        public string PokazKlientow(int index)
        {
            var clientRepository = new ClientRepository();
            clientRepository.Get();
            throw new NotImplementedException();
        }

        public int IleKlientow()
        {
            return klienci.Count;
        }
        
    }
}