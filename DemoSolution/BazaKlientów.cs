using System;
using System.Collections.Generic;
using System.Text;

namespace DemoSolution
{
    class BazaKlientów
    {
        List<string> klienci = new List<string>()
        {
            "Jon Smith, nr rejestracyjny: SMI XXXX",
            "Donal Trump, nr rejestracyjny: SMI YYYY",
        };



        string Imie;
        string Nazwisko;
        string rejestracjaSamochodu;


        public void DodajKlienta(string klient)
        {
            Console.WriteLine(" Podaj Imię klienta");
            Imie = Console.ReadLine();
            Console.WriteLine(" Podaj Nazwisko klienta");
            Nazwisko = Console.ReadLine();
            Console.WriteLine(" Podaj numer rejestracyjny pojazdu klienta");
            rejestracjaSamochodu = Console.ReadLine();

            klient = Imie + " " + Nazwisko + ", nr rejestracyjny:" + rejestracjaSamochodu;
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
        public int ileKlientow()
        {
            return klienci.Count;
        }

    }
}
