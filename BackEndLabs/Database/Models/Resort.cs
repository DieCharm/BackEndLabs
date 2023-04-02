using System.ComponentModel.DataAnnotations;

namespace BackEndLabs.Database.Models;

public class Resort
{
    public int Id { get; set; }
    [MaxLength(40)]
    public string Name { get; set; }
    public string Country { get; set; }
    [Range(0.0, Double.MaxValue, ErrorMessage = "Wrong price value")]
    public decimal DailyPrice { get; set; }
}