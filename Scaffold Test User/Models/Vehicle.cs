using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Scaffold_Test_User.Models
{
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]

        public double Price { get; set; }
        [Required]
        [DisplayName("Czy pojazd jest wynajęty")]
        public bool Taken { get; set; } = false;
        public int? ClientId { get; set; }
        public string? Description { get; set; }
    }
}
