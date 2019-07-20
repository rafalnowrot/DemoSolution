using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DemoSolution.Infrastructure
{
    public class FileRepository
    {
        private static ClientService _clientService = new ClientService();

        internal static void SaveAsTXT()
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
    }
}
