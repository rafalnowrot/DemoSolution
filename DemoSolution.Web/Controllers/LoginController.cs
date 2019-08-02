using System.Threading.Tasks;
using DemoSolution.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using DemoSolution.Infrastructure;

namespace DemoSolution.Web.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login([Bind("Email,Password")] LoginViewModel loginCommand)
        {
            if(!ModelState.IsValid)
            {
                return RedirectToAction(nameof(Index));
            }

            var employeerService = new EmployeerService();
            var isEmailAndPasswordValid = employeerService.IsEmailAndPasswordValid(loginCommand.Email, loginCommand.Password);

            if (!isEmailAndPasswordValid)
            {
                return RedirectToAction(nameof(Index)); 
            }

            return View("~/Views/Home/Index.cshtml");
        }
    }
    
}