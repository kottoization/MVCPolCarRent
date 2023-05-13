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
        public async Task<IActionResult> Create(int vehicleId, DateTime start, DateTime finish)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var reservation = new Reservation
            {
                UserId = userId,
                VehicleId = vehicleId,
                Finish = finish,
                Start = start,
            };

            _context.Add(reservation);
            await _context.SaveChangesAsync();

            var vehicle = await _context.Vehicles.FindAsync(vehicleId);
            vehicle.Taken = true;

            _context.Update(vehicle);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index), "Home");
        }

        
        public async Task<IActionResult> CreateReservation(int? vehicleId)
        {
            var vehicle = await _context.Vehicles.FindAsync(vehicleId);

            if (vehicleId == null || vehicle == null)
            {
                return NotFound();
            }
            var reservation = new Reservation();
            return View(Tuple.Create(vehicle,reservation));
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

