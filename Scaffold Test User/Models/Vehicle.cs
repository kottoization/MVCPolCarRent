using Scaffold_Test_User.Areas.Identity.Data;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Scaffold_Test_User.Models
{
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Nazwa")]
        public string Name { get; set; }
        [Required]
        [DisplayName("Cena")]
        public double Price { get; set; }
        [Required]
        [DisplayName("Czy pojazd jest wynajęty")]
        public bool Taken { get; set; } = false;
        
        [DisplayName("Opis")]
        public string? Description { get; set; }

        
    }
}
