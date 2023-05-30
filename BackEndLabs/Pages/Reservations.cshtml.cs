using BackEndLabs.Database;
using BackEndLabs.Database.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BackEndLabs.Pages;

public class Reservations : PageModel
{
    private readonly TourDbContext _context;
    public List<Reservation> ReservationsSet { get; set; }

    public Reservations(TourDbContext context)
    {
        _context = context;
    }
    
    public void OnGet()
    {
        ReservationsSet = _context.Reservations
            .Include(reservation => reservation.Tourist)
            .Include(reservation => reservation.Resort)
            .ToList();
    }
}