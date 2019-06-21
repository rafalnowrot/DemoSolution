using System;
using System.IO;

namespace DemoSolution
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int exit;
            ClientService Lista = new ClientService();
            string klient = "";
            int zmienna = 0;
            do
            {
                Console.WriteLine("MenuGłówne");
                Console.WriteLine("Podaj co chcesz zrobić wciskając odpowiedni numer:");
                Console.WriteLine("[1].Naprawa Silnika z dodatkami");
                Console.WriteLine("[2].Dodaj Klientów do listy");
                Console.WriteLine("[3].Wyświetl Listę klientów z pliku");
                Console.WriteLine("[4].Zapisz klientów z pliku .txt w folderze na pulpicie");

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
                        int rozmiar = Lista.IleKlientow();
                        for (int i = 0; i < rozmiar; i++)
                        {
                            klient = Lista.PokazKlientow(i);
                            Console.WriteLine(klient);
                        }
                        break;
                    case 4:
                        int liczbaklientow = Lista.IleKlientow();
                        var desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                        var directoryPath = $"{desktopPath}\\Listaklientow";
                        if (!Directory.Exists(directoryPath))
                        {
                            Directory.CreateDirectory(directoryPath);
                        }
                        else
                        {
                            Console.WriteLine("Katalog już istnieje");
                            Console.ReadKey();
                        }
                        if (!File.Exists($"{desktopPath}\\Listaklientow"))
                        {
                            StreamWriter sw = File.CreateText($"{desktopPath}\\Listaklientow\\plik.txt");
                            for (int i = 0; i < liczbaklientow; i++)
                            {
                            sw.WriteLine(Lista.PokazKlientow(i));
                            }
                            sw.Close();
                        }
                        break;
                    default:
                        Console.WriteLine("Podano złą komendę!");
                        break;
                }
                   Console.WriteLine("Jeśli chcesz wyjść wciśnie '0'. Jeśli nie, wciśnij dowolną cyfrę");
                   exit = Convert.ToInt32(Console.ReadLine());
            }while (exit != 0) ;
        }
        private static void Sprzdaz(int k465)
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
