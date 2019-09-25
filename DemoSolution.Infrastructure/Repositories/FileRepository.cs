using DemoSolution.Core;
using System;
using System.Collections.Generic;
using System.IO;

namespace DemoSolution.Infrastructure
{
    public class FileRepository
    {
        public static void SaveAsTxt(List<Client> clients, string desktopPath)
        {
            var directoryPath = $"{desktopPath}\\Listaklientow";
            Directory.CreateDirectory(directoryPath);
       
            using (StreamWriter streamWriter = File.CreateText($"{directoryPath}\\plik.txt"))
            {
                foreach (var client in clients)
                {
                    streamWriter.WriteLine(
                        $"Imię: '{client.FirstName}', " 
                        + $"nazwisko: '{client.Surname}', " 
                        + $"Data_utworzenia: '{client.CreatedAt}', "
                        + $"Pracownik: '{client.CreatedBy}'"
                    );
                }

                streamWriter.Flush();
            }
        }
    }
}