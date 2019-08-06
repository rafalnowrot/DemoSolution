using System;
using DemoSolution.Core;
using DemoSolution.Infrastructure.Repositories;

namespace DemoSolution.Infrastructure
{
    public class EmployeerService
    {
        private readonly EmployeerRepository _employeerRepository = new EmployeerRepository();
        public int employeerID;
        
        public bool IsEmailAndPasswordValid(string email, string password)
        {
           var employeer = _employeerRepository.Get(email, password);

            if (employeer is null)
            {
                return false;
            }
            else
            {
             employeerID = employeer.Id;
            return true;

            }

        }

        public Employeer ShowEmployeerAccount()
        {
            var employeer = _employeerRepository.GetOne(employeerID);

            return employeer;
        }
    }
}