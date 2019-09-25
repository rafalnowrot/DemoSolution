using System;

namespace DemoSolution.Infrastructure
{
    public class FileService
    {
        public static void SaveAsTXT()
        {
            var clientService = new ClientService();
            var clients = clientService.GetClients();

            FileRepository.SaveAsTxt(clients, Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
        }
    }
}
