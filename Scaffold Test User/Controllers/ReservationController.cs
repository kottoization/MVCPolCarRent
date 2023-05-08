using Microsoft.AspNetCore.Mvc;
using Scaffold_Test_User.Areas.Identity.Data;
using Scaffold_Test_User.Models;
using System.Security.Claims;

namespace Scaffold_Test_User.Controllers
{
    public class ReservationController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReservationController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int vehicleId)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var reservation = new Reservation
            {
                UserId = userId,
                VehicleId = vehicleId
            };
            _context.Add(reservation);
            await _context.SaveChangesAsync();
            var vehicle = await _context.Vehicles.FindAsync(vehicleId);
            vehicle.Taken = true;
            _context.Update(vehicle);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index), "Home");
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int reservationId)
        {
            var reservation = await _context.Reservations.FindAsync(reservationId);

            if (reservation != null)
            {
                _context.Remove(reservation);
                await _context.SaveChangesAsync();

                var vehicle = await _context.Vehicles.FindAsync(reservation.VehicleId);
                vehicle.Taken = false;
                _context.Update(vehicle);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }
    }

}

