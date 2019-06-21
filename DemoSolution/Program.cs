using DemoSolution.Infrastructure;
using System;
using System.IO;

namespace DemoSolution
{
    public class Program
    {
        private static ClientService _clientService = new ClientService();

        public static void Main(string[] args)
        {
            int exit;
            string klient = "";
            int zmienna = 0;
            do
            {
                Console.WriteLine("MenuGłówne");
                Console.WriteLine("Podaj co chcesz zrobić wciskając odpowiedni numer:");
                Console.WriteLine("[1].Naprawa Silnika z dodatkami");
                Console.WriteLine("[2].Dodaj Klientów do listy");
                Console.WriteLine("[3].Usuń klienta z listy");
                Console.WriteLine("[4].Wyświetl Listę klientów z pliku");
                Console.WriteLine("[5].Zapisz klientów z pliku .txt w folderze na pulpicie");

                zmienna = Convert.ToInt32(Console.ReadLine());

                switch (zmienna)
                {
                    case 1:
                        Sprzdaz(0);
                        break;
                    case 2:
                        AddClient();
                        break;
                    case 3:
                        DeleteClient();
                        break;
                    case 4:
                        ShowClients();
                        break;
                    case 5:
                        SaveAsTXT();
                        break;
                    default:
                        Console.WriteLine("Podano złą komendę!");
                        break;
                }
                Console.WriteLine("Jeśli chcesz wyjść wciśnie '0'. Jeśli nie, wciśnij dowolną cyfrę");
                exit = Convert.ToInt32(Console.ReadLine());
            } while (exit != 0);
        }

        private static void AddClient()
        {
            var userName = Environment.UserName;
            var firstName = Console.ReadLine();
            var surname = Console.ReadLine();
            var plataName = Console.ReadLine();
            _clientService.AddClient(userName, firstName, surname, plataName);
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

        private static void ShowClients()
        {
            var clients = _clientService.GetClients();
            foreach (var client in clients)
            {
                Console.WriteLine($"Imię: '{client.FirstName}', nazwisko: '{client.Surname}'");
            }
        }

        private static void SaveAsTXT()
        {
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
                var clients = _clientService.GetClients();
                foreach (var client in clients)
                {
                    sw.WriteLine(
                        $"Imię: '{client.FirstName}', nazwisko: '{client.Surname}', nr_rejestracyjny: '{client.PlateName}', " +
                        $"Data_utworzenia: '{client.CreatedAt}', Pracownik: '{client.CreatedBy}'");
                }

                sw.Close();
            }
        }

        private static void DeleteClient()
        {
            Console.WriteLine("Podaj nr ID klienta do usunięcia");
            int id = Convert.ToInt32(Console.ReadLine());
            _clientService.DeleteClient(id);
        }
    }
}
