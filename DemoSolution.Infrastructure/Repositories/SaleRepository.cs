using System;
using System.Collections.Generic;
using System.Text;

namespace DemoSolution.Infrastructure
{
    public class SaleRepository
    {
        internal static void Sale()
        {
            Console.WriteLine("Podaj model silnika:");
            string silnik = Console.ReadLine();
            Console.WriteLine("Podaj ile wynosi jego cena:");
            decimal cenaSilnika = int.Parse(Console.ReadLine());
            decimal cenaKoncowa;
            Console.WriteLine("czy klient chce zimowe opony? t/n");
            string opony = Console.ReadLine();
            Console.WriteLine("czy klient chce klimatyzacje? t/n");
            string klimatyzacja = Console.ReadLine();
            Console.WriteLine("czy klient chce autoalarm? t/n");
            string autoAlarm = Console.ReadLine();
            if (opony == "t" && klimatyzacja == "t" && autoAlarm == "t")
            {
                Console.WriteLine("Podaj cenę Opon:");
                decimal cenaOpon = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Podaj cenę klimatyzacji:");
                decimal cenaKlimatyzacji = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Podaj cenę alarmu:");
                decimal cenaAlarmu = Convert.ToDecimal(Console.ReadLine());
                cenaKoncowa = cenaSilnika + cenaOpon + cenaKlimatyzacji + cenaAlarmu;
                Console.WriteLine($"Cena wynosi: {cenaKoncowa}");
            }
            else if (opony == "t" && klimatyzacja == "n" && autoAlarm == "n")
            {
                Console.WriteLine("Podaj cenę Opon:");
                decimal cenaOpon = Convert.ToDecimal(Console.ReadLine());
                cenaKoncowa = cenaSilnika + cenaOpon;
                Console.WriteLine($"Cena wynosi: {cenaKoncowa}");
            }
            else if (opony == "t" && klimatyzacja == "t" && autoAlarm == "n")
            {
                Console.WriteLine("Podaj cenę Opon:");
                decimal cenaOpon = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Podaj cenę klimatyzacji:");
                decimal cenaKlimatyzacji = Convert.ToDecimal(Console.ReadLine());
                cenaKoncowa = cenaSilnika + cenaKlimatyzacji + cenaOpon;
                Console.WriteLine($"Cena wynosi: {cenaKoncowa}");
            }
            else if (opony == "n" && klimatyzacja == "t" && autoAlarm == "t")
            {
                Console.WriteLine("Podaj cenę klimatyzacji:");
                decimal cenaKlimatyzacji = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Podaj cenę alarmu:");
                decimal cenaAlarmu = Convert.ToDecimal(Console.ReadLine());
                cenaKoncowa = cenaSilnika + cenaKlimatyzacji + cenaAlarmu;
                Console.WriteLine($"Cena wynosi: {cenaKoncowa}");
            }
            else if (opony == "n" && klimatyzacja == "n" && autoAlarm == "t")
            {
                Console.WriteLine("Podaj cenę alarmu:");
                decimal cenaAlarmu = Convert.ToDecimal(Console.ReadLine());
                cenaKoncowa = cenaSilnika + cenaAlarmu;
                Console.WriteLine($"Cena wynosi: {cenaKoncowa}");
            }
            else if (opony == "n" && klimatyzacja == "n" && autoAlarm == "n")
            {
                cenaKoncowa = cenaSilnika;
                Console.WriteLine($"Cena wynosi: {cenaKoncowa}");
            }
            else if (opony == "t" && klimatyzacja == "n" && autoAlarm == "t")
            {
                Console.WriteLine("Podaj cenę Opon:");
                decimal cenaOpon = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Podaj cenę alarmu:");
                decimal cenaAlarmu = Convert.ToDecimal(Console.ReadLine());
                cenaKoncowa = cenaSilnika + cenaAlarmu;
                Console.WriteLine($"Cena wynosi: {cenaKoncowa}");
            }
            else if (opony == "n" && klimatyzacja == "t" && autoAlarm == "n")
            {
                Console.WriteLine("Podaj cenę klimatyzacji:");
                decimal cenaKlimatyzacji = Convert.ToDecimal(Console.ReadLine());
                cenaKoncowa = cenaSilnika + cenaKlimatyzacji;
                Console.WriteLine($"Cena wynosi: {cenaKoncowa}");
            }

            Console.ReadLine();
        }
    }
}
