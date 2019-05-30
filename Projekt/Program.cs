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
            Console.WriteLine("Podaj Pracownika np Rafal_Nowrot:");
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
            


            Console.ReadKey();
        }
    }
}
