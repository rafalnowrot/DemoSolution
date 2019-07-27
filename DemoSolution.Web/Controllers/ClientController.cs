using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using DemoSolution.Core;
using DemoSolution.Infrastructure;
using DemoSolution.Web.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;

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

        public IActionResult Edit(int id)
        {
            var clientService = new ClientService();
            var clients = clientService.GetClients();
            var client = clients.Single(x => x.Id == id);

            var clientViewModel = new ClientViewModel
            {
                Id = client.Id,
                FirstName = client.FirstName,
                Surname = client.Surname,
                PlateName = client.PlateName
            };

            return View(clientViewModel);
        }
        // POST: Movies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,Surname,PlateName")] ClientViewModel client)
        {
            var clientService = new ClientService();
            clientService.UpdateClient(id, client.PlateName);
            return RedirectToAction(nameof(Index));
        }

        // GET: Movies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Movies/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(
            [Bind("Id,FirstName,Surname,PlateName")] ClientViewModel client)
        {
            if (ModelState.IsValid)
            {
                var clientService = new ClientService();
                clientService.AddClient(client.FirstName, client.Surname, client.PlateName);
                
                return RedirectToAction("Index");
            }
            return RedirectToAction(nameof(Index));
            //return View();
        }

        // GET: Movies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientService = new ClientService();
            var clients = clientService.GetClients();
            var client = clients.Single(x => x.Id == id);
            if (client == null)
            {
                return NotFound();
            }
            var clientViewModel = new ClientViewModel
            {
                Id = client.Id,
                FirstName = client.FirstName,
                Surname = client.Surname,
                PlateName = client.PlateName
            };

            return View(clientViewModel);

            //return View(clients);
        }

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var clientService = new ClientService();
            clientService.DeleteClient(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
