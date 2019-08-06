using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoSolution.Infrastructure;
using DemoSolution.Web.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using DemoSolution.Core;

namespace DemoSolution.Web.Controllers
{
    public class AccountController : Controller
    {
        //private readonly UserManager<IdentityUser> userManager;
        //private readonly SignInManager<IdentityUser> singInManager;

  
        public IActionResult Index(Employeer employeer)
        {
        var employeerService = new EmployeerService();
           employeer = null; 
            
            return View(employeer);
        }

        //public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        //{
        //    this.userManager = userManager;
        //    this.singInManager = signInManager;
        //}
        

    }
}