using System;
using System.ComponentModel.DataAnnotations;

namespace DemoSolution.Web.ViewModels
{
    public class CarViewModel
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