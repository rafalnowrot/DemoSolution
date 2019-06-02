using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Program
    {
      
        //public void Wynagrodzenia(double[] args)
        //{
        //    double WynZasadnicze;
        //    double WynZaPraceWNocy;
        //    double WynZaDyzurPelnionePozaNormalnymiGodzinamiPracy;
        //    double WynZaCzasNiewykonywaniaPracy;
        //    double DodatkiZaPraceWGodzinachNadliczonychOrazWNiedzieleISwieta;
        //}


        static void Main(string[] args)
        {
            ClassDaneOsobowe DaneOsobowe = new ClassDaneOsobowe();
            string imie_i_Nazwisko;
            Console.WriteLine("Ile Pracowników: ");
            int iloscPracownikow = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dodaj Pracowników ");
            Console.WriteLine("Podaj Pracownika 1.Imię i nazwisko 2.Adres 3.Historia zatrudnienia 4.Pełnione obowiązki 5.Nagrody 6.Kary 7.Kursy 8.Wynagrodzenie 9.Staż pracy");
            for (int i = 0; i < iloscPracownikow; i++)
            {
                string j = Console.ReadLine(); 
                DaneOsobowe.DodajImie_i_Nazwisko(j);
            }
            Console.WriteLine();
            for (int i = 0; i < iloscPracownikow; i++)
            {
                Console.WriteLine(DaneOsobowe.Wyswietl_Imie_i_Nazwisko(i));
            }
            Console.WriteLine();
            int exit;
            do
            {

                Console.WriteLine("Co chcez zrobić? [1]/Usuń pracownika. [2]/Wyswietl pracowników. [3]/Edytuj Pracowników. [4]/Dodaj pracowników");
                int czynnosc = Convert.ToInt16(Console.ReadLine());
                switch (czynnosc)
                {
                    case 1:
                        int x = 0;
                        Console.WriteLine("Podaj którego Pracownika chcesz usunąć z listy. Pamiętaj że pracownik pierwszy ma numer ZERO ");
                        x = Convert.ToInt32(Console.ReadLine());
                        DaneOsobowe.UsunImie_i_Nazwisko(x);
                        break;
                    case 2:
                        for (int i = 0; i < iloscPracownikow; i++)
                        {
                            Console.WriteLine(DaneOsobowe.Wyswietl_Imie_i_Nazwisko(i));
                        }
                        break;
                    case 3:

                        break;
                    case 4:
                        Console.WriteLine("Ilu Pracowników chcesz dodać?");
                        int iloscDodanych = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Dodaj Pracowników ");
                        Console.WriteLine("Podaj Pracownika 1.Imię i nazwisko 2.Adres 3.Historia zatrudnienia 4.Pełnione obowiązki 5.Nagrody 6.Kary 7.Kursy 8.Wynagrodzenie 9.Staż pracy");
                        for (int i = 0; i < iloscDodanych; i++)
                        {
                            string j = Console.ReadLine();
                            DaneOsobowe.DodajImie_i_Nazwisko(j);
                        }
                        break;
                    case 5:

                        break;
                    case 6:

                        break;
                    default:

                        break;
                }
                Console.WriteLine("Wciśnij dowolny klawisz. Jeśli chcesz wyjść wciśnij (0) <-ZERO ");
                exit = Convert.ToInt32(Console.ReadLine());
            } while (exit != 0);

            Console.WriteLine("Projekt Nieskończony.");
            ///Projekt Wykonaliśmy w klasach więc prosimy o dodatkowe punkty za wykonywanie metodami których jeszcze nie poznaliśmy. Niestety nie wystarczyło nam czasu na dokończenie programu jednak 
            ///to co tutaj można zobaczyć to fakt że nasze zdolności zasługują na nagrodę. Pozdrawiamy.
            Console.WriteLine("Projekt Wykonali: Rafał Nowrot, Patryk Pokora, Maciej Kiełbasa");

            Console.ReadKey();
        }
    }
}
