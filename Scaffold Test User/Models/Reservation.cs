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
        [DisplayName("Ilość dni :")]
        public int NumberOfDays { get; set; }
        //dac datetime start i koniec, stworzyc implementacje z lista rezerwacji i sortowaniem
        public ApplicationUser User { get; set; }
        public Vehicle Vehicle { get; set; }    

    }
}
