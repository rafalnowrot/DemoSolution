using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using DemoSolution.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoSolution.Web.Controllers
{
    public class ClientController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var clientService = new ClientService();
            var clients = clientService.GetClients();

            return View(clients);
        }

        //public ActionResult Create()

        //{
        //    var clientService = new ClientService();
        //    string fName =  ;
        //    string sName = ;
        //    string pName = ;

        //    var clients = clientService.AddClient(fName, sName, pName)

        //    return View();

        //}

    }
}
