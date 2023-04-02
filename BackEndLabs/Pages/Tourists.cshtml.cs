using BackEndLabs.Database;
using BackEndLabs.Database.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BackEndLabs.Pages;

public class Tourists : PageModel
{
    private readonly TourDbContext _context;
    public List<Tourist> TouristsSet { get; set; }

    public Tourists(TourDbContext context)
    {
        _context = context;
    }
    
    public void OnGet()
    {
        TouristsSet = _context.Tourists.ToList();
    }
}