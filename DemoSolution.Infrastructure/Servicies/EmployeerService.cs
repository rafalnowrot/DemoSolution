using DemoSolution.Infrastructure.Repositories;

namespace DemoSolution.Infrastructure
{
    public class EmployeerService
    {
        private readonly EmployeerRepository _employeerRepository = new EmployeerRepository();

        public bool IsEmailAndPasswordValid(string email, string password)
        {
            var employeer = _employeerRepository.Get(email, password);

            if (employeer is null)
            {
                return false;
            }

            return true;
        }
    }
}