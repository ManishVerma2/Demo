using System.ComponentModel.DataAnnotations;

namespace Demotostart.Models
{
    public class Country
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Country name id required")]
        public required string Name { get; set; }
    }
}
