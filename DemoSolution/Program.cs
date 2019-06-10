using System;

namespace DemoSolution
{
    class Program
    {

        static void Main(string[] args)
        {
            int exit;
            BazaKlientów Lista = new BazaKlientów();
            string klient = "";
            int zmienna = 0;
            do
            {
                Console.WriteLine("MenuGłówne");
                Console.WriteLine("Podaj co chcesz zrobić wciskając odpowiedni numer:");
                Console.WriteLine("[1].Naprawa Silnika z dodatkami");
                Console.WriteLine("[2].Dodaj Klientów do listy");
                Console.WriteLine("[3].Wyświetl Listę klientów z pliku");

                zmienna = Convert.ToInt32(Console.ReadLine());

                switch (zmienna)
                {
                    case 1:
                        Sprzdaz(0);
                        break;
                    case 2:
                        Lista.DodajKlienta(klient);
                        break;
                    case 3:
                        int rozmiar = Lista.ileKlientow();
                        for (int i = 0; i < rozmiar; i++)
                        {
                            klient = Lista.PokazKlientow(i);
                            Console.WriteLine(klient);
                        }

                        break;
                    default:
                        Console.WriteLine("Podano złą komendę!");
                        break;
                }
                Console.WriteLine("Jeśli chcesz wyjść wciśnie '0'. Jeśli nie, wciśnij dowolną cyfrę");
                exit = Convert.ToInt32(Console.ReadLine());
            } while (exit != 0);
            //Console.ReadKey();

        }


        static void Sprzdaz(int k465)
        {
            Console.WriteLine("Podaj model silnika:");
            string silnik = Console.ReadLine();
            Console.WriteLine("Podaj ile wynosi jego cena:");
            decimal cenaSilnika = int.Parse(Console.ReadLine());
            decimal cenakoncowa1;


            Console.WriteLine("czy klient chce zimowe opony? t/n");
            string opony = Console.ReadLine();
            Console.WriteLine("czy klient chce klimatyzacje? t/n");
            string klimatyzacja = Console.ReadLine();
            Console.WriteLine("czy klient chce autoalarm? t/n");
            string autoalarm = Console.ReadLine();
            if (opony == "t" && klimatyzacja == "t" && autoalarm == "t")
            {
                Console.WriteLine("Podaj cenę Opon:");
                decimal cenaOpon = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Podaj cenę klimatyzacji:");
                decimal cenaKlimatyzacji = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Podaj cenę alarmu:");
                decimal cenaAlarmu = Convert.ToDecimal(Console.ReadLine());


                cenakoncowa1 = cenaSilnika + cenaOpon + cenaKlimatyzacji + cenaAlarmu;
                Console.WriteLine($"Cena wynosi: {cenakoncowa1}");
            }
            if (opony == "t" && klimatyzacja == "n" && autoalarm == "n")
            {
                Console.WriteLine("Podaj cenę Opon:");
                decimal cenaOpon = Convert.ToDecimal(Console.ReadLine());

                cenakoncowa1 = cenaSilnika + cenaOpon;
                Console.WriteLine($"Cena wynosi: {cenakoncowa1}");
            }
            if (opony == "t" && klimatyzacja == "t" && autoalarm == "n")
            {
                Console.WriteLine("Podaj cenę Opon:");
                decimal cenaOpon = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Podaj cenę klimatyzacji:");
                decimal cenaKlimatyzacji = Convert.ToDecimal(Console.ReadLine());

                cenakoncowa1 = cenaSilnika + cenaKlimatyzacji + cenaOpon;
                Console.WriteLine($"Cena wynosi: {cenakoncowa1}");
            }
            if (opony == "n" && klimatyzacja == "t" && autoalarm == "t")
            {

                Console.WriteLine("Podaj cenę klimatyzacji:");
                decimal cenaKlimatyzacji = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Podaj cenę alarmu:");
                decimal cenaAlarmu = Convert.ToDecimal(Console.ReadLine());


                cenakoncowa1 = cenaSilnika + cenaKlimatyzacji + cenaAlarmu;
                Console.WriteLine($"Cena wynosi: {cenakoncowa1}");
            }
            if (opony == "n" && klimatyzacja == "n" && autoalarm == "t")
            {
                Console.WriteLine("Podaj cenę alarmu:");
                decimal cenaAlarmu = Convert.ToDecimal(Console.ReadLine());


                cenakoncowa1 = cenaSilnika + cenaAlarmu;
                Console.WriteLine($"Cena wynosi: {cenakoncowa1}");
            }
            if (opony == "n" && klimatyzacja == "n" && autoalarm == "n")
            {
                cenakoncowa1 = cenaSilnika;
                Console.WriteLine($"Cena wynosi: {cenakoncowa1}");
            }
            if (opony == "t" && klimatyzacja == "n" && autoalarm == "t")
            {
                Console.WriteLine("Podaj cenę Opon:");
                decimal cenaOpon = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Podaj cenę alarmu:");
                decimal cenaAlarmu = Convert.ToDecimal(Console.ReadLine());

                cenakoncowa1 = cenaSilnika + cenaAlarmu;
                Console.WriteLine($"Cena wynosi: {cenakoncowa1}");
            }
            if (opony == "n" && klimatyzacja == "t" && autoalarm == "n")
            {

                Console.WriteLine("Podaj cenę klimatyzacji:");
                decimal cenaKlimatyzacji = Convert.ToDecimal(Console.ReadLine());

                cenakoncowa1 = cenaSilnika + cenaKlimatyzacji;
                Console.WriteLine($"Cena wynosi: {cenakoncowa1}");
            }

            Console.ReadLine();
        }
    }
}
