using Microsoft.EntityFrameworkCore;
using Scaffold_Test_User.Models;

namespace Scaffold_Test_User.Areas.Identity.Data
{
    public class VehiclesDbContext : DbContext 
    {
        public VehiclesDbContext(DbContextOptions<VehiclesDbContext> option) : base(option) { }
        
        public DbSet<Vehicle> Vehicles { get; set ; }


        
    }
}
