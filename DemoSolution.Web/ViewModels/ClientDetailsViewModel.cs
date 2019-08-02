using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DemoSolution.Web.ViewModels
{
    public class ClientDetailsViewModel
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string FirstName { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Surname { get; set; }

        public List<CarViewModel> Cars { get; set; }
    }
}