using DemoSolution.Infrastructure.Repositories;

namespace DemoSolution.Infrastructure
{
    public class EmployeerService
    {
        private readonly EmployeerRepository _employeerRepository = new EmployeerRepository();

        public int IsUserLogged = 0;

        public bool IsEmailAndPasswordValid(string email, string password)
        {
           var employeer = _employeerRepository.Get(email, password);

            if (employeer is null)
            {
                return false;
            }
            // TODO: metoda w Repository-> dajemy ID Employeer i zmieniamy na Online w tabeli. Potem w Account Details wywołujemy tego który jest Online :D 


            //IsUserLogged = employeer.Id;
            return true;
        }

        //public Employeer ShowEmployeerAccount()
        //{
        //    var employeer = _employeerRepository.GetOne(employeerID);

        //    return employeer;
        //}
    }
}