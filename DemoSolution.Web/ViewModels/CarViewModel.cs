using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DemoSolution.Web.ViewModels
{
    public class CarViewModel : Controller
    {
        public Guid Id { get; set; }

        [StringLength(60, MinimumLength = 1)]
        [Required]
        public string BrandName { get; set; }

        [StringLength(60, MinimumLength = 1)]
        [Required]
        public string Model { get; set; }

        public int ClientId { get; set; }

    }
}