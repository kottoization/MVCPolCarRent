using Scaffold_Test_User.Areas.Identity.Data;

namespace Scaffold_Test_User.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int VehicleId { get; set; }
        public virtual ApplicationUser User { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}
