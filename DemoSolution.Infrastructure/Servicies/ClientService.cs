using System;
using System.Collections.Generic;
using DemoSolution.Core;

namespace DemoSolution.Infrastructure
{
    public class ClientService
    {
        private readonly ClientRepository _clientRepository = new ClientRepository();

        public void DeleteClient(int id)
        {
            _clientRepository.Delete(id);
        }

        public List<Client> GetClients()
        {    
            return _clientRepository.Get();
        }

        public void AddClient(string firstName, string surname, string plateName)
        {
            var client = new Client();
            client.FirstName = firstName;
            client.Surname = surname;
            client.PlateName = plateName;
            client.CreatedBy = Environment.UserName;
            client.CreatedAt = DateTime.UtcNow;
            _clientRepository.Add(client);
        }

        public void UpdateClient(int id, string newNumber)
        {
            _clientRepository.Update(id, newNumber);
        }
    }
}