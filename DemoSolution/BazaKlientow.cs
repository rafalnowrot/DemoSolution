using System;
using System.Collections.Generic;

namespace DemoSolution
{
    public class BazaKlientow
    {
        private List<string> klienci = new List<string>()
        {
            "Jon Smith, nr rejestracyjny: SMI XXXX",
            "Donal Trump, nr rejestracyjny: SMI YYYY",
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

            klient = imie + " " + nazwisko + ", nr rejestracyjny:" + rejestracjaSamochodu;
            klienci.Add(klient);
        }

        public void UsunKlienta(string klient)
        {
            klienci.Remove(klient);
        }

        public string PokazKlientow(int index)
        {
            return klienci[index];
        }

        public int IleKlientow()
        {
            return klienci.Count;
        }
    }
}