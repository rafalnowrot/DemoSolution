using System;
using System.Collections.Generic;
using DemoSolution.Core;

namespace DemoSolution.Infrastructure
{
    public class ClientService
    {
        private readonly ClientRepository _clientRepository = new ClientRepository();

        public List<Client> GetClients()
        {    
            return _clientRepository.Get();
        }

        public Client GetClient(int id)
        {
            return  _clientRepository.Get(id);
        }

        public void AddClient(string firstName, string surname)
        {
            var client = new Client
            {
                FirstName = firstName,
                Surname = surname,
                CreatedBy = Environment.UserName,
                CreatedAt = DateTime.UtcNow
            };

            _clientRepository.Add(client);
        }

        public void UpdateClient(int id, string newFirstName, string newSurname)
        {
            _clientRepository.Update(id, newFirstName, newSurname);
        }

        public void DeleteClient(int id)
        {
            _clientRepository.Delete(id);
        }
    }
}