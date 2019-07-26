using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DemoSolution.Web.ViewModels
{
    public class CarViewModel : Controller
    {
        public Guid Id { get; set; }
        public string BrandName { get; set; }
        public string Model { get; set; }
        public int ClientId { get; set; }

    }
}