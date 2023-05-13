using Scaffold_Test_User.Areas.Identity.Data;
using System.ComponentModel;

namespace Scaffold_Test_User.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int VehicleId { get; set; }
        [DisplayName("Cena :")]
        public int Price { get; set; }
        [DisplayName("Dzień rozpoczęcia rezerwacji :")]
        public DateTime Start { get; set; }
        [DisplayName("Dzień zakończenia rezerwacji :")]
        public DateTime Finish { get; set; }
        
        public ApplicationUser User { get; set; }
        public Vehicle Vehicle { get; set; }    

    }
}
