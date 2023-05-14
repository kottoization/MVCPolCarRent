using Scaffold_Test_User.Areas.Identity.Data;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Scaffold_Test_User.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int VehicleId { get; set; }
        [DisplayName("Cena :")]
        public double Price { get; set; }
        [Required]
        [DisplayName("Dzień rozpoczęcia rezerwacji :")]
        public DateTime Start { get; set; }
        [Required]
        [DisplayName("Dzień zakończenia rezerwacji :")]
        public DateTime Finish { get; set; }
        
        public ApplicationUser User { get; set; }
        public Vehicle Vehicle { get; set; }  
        
        public int Discount { get; set; }
        
    }
}
