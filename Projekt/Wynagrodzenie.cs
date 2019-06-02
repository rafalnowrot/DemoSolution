using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Projekt
{
    public class Wynagrodzenie
    {
        public void Wynagrodzenia(double wynagrodzenie_zasadnicze, double wynagrodzenie_nocne, double dyzury, double l4, double dodatki)
        { 
        Console.WriteLine("Wprowadz nowe wynagrodzenie:");
            Console.WriteLine("Podaj wynagrodzenie zasadnicze:");
            wynagrodzenie_zasadnicze = double.Parse(Console.ReadLine());
        Console.WriteLine("Podaj wynagrodzenie za pracę w nocy:");
            wynagrodzenie_nocne = double.Parse(Console.ReadLine());
        Console.WriteLine("Podaj wynagrodzenie dyżury pełnione poza normalnymi godzinami pracy:");
            dyzury = double.Parse(Console.ReadLine());
        Console.WriteLine("Podaj wynagrodzenie za czas niewykonywania pracy:");
            l4 = double.Parse(Console.ReadLine());
        Console.WriteLine("Podaj dodatki za pracę w godzinach nadliczbowych oraz w niedziele i święta");
             dodatki = double.Parse(Console.ReadLine());

        double przychod = wynagrodzenie_zasadnicze + wynagrodzenie_nocne + dyzury + l4 + dodatki;

        double skladka_emerytalna = 0.0976 * przychod;
        double skladka_rentowa = 0.015 * przychod;
        double skladka_chorobowa = 0.0245 * przychod;

        double netto = przychod - skladka_emerytalna - skladka_rentowa - skladka_chorobowa;
        netto = Math.Round(netto, 2);
        }
    }
}