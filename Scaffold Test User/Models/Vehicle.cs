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
        // [DisplayName("ID klienta")]
        //public int? ClientId { get; set; }
        [DisplayName("Opis")]
        public string? Description { get; set; }

        public string? UserId { get; set; }
        public ApplicationUser? User { get; set; }

        public void Rent(ApplicationUser user)
        {
            this.Taken = true;
            this.User = user;
            user.Reservations.Add(this);
        }

        public void Return()
        {
            this.Taken = false;
            this.User.Reservations.Remove(this);
            this.User = null;
        }
    }
}
