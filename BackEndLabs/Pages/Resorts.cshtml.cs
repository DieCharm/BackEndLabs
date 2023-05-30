using BackEndLabs.Database;
using BackEndLabs.Database.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BackEndLabs.Pages;

public class Resorts : PageModel
{
    private readonly TourDbContext _context;
    public List<Resort> ResortsSet { get; set; }

    public Resorts(TourDbContext context)
    {
        _context = context;
    }
    
    public void OnGet()
    {
        ResortsSet = _context.Resorts.ToList();
    }
}