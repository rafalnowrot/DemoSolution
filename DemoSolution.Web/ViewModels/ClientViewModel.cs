using System.ComponentModel.DataAnnotations;

namespace DemoSolution.Web.ViewModel
{
    public class ClientViewModel
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string FirstName { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Surname { get; set; }


    }
}