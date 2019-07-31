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

        public void AddClient(string firstName, string surname)
        {
            var client = new Client();
            client.FirstName = firstName;
            client.Surname = surname;
            client.CreatedBy = Environment.UserName;
            client.CreatedAt = DateTime.UtcNow;
            _clientRepository.Add(client);
        }

        public void UpdateClient(int id, string newNumber, string newSurname)
        {
            _clientRepository.Update(id, newNumber, newSurname);
        }

        public Client ShowOneClient(int id)
        {
            return  _clientRepository.ShowOneClient(id);
        }
    }
}