using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DemoSolution.Web.ViewModels
{
    public class ClientDetailsViewModel : Controller
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string FirstName { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Surname { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string PlateName { get; set; }

        public Guid ID { get; set; }

        [StringLength(60, MinimumLength = 1)]
        [Required]
        public string BrandName { get; set; }

        [StringLength(60, MinimumLength = 1)]
        [Required]
        public string Model { get; set; }

        public int ClientId { get; set; }

    }
}