using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEndLabs.Database.Models;

public class Reservation
{
    [ForeignKey("Tourist")]
    public int TouristId { get; set; }
    [ForeignKey("Resort")]
    public int ResortId { get; set; }
    public Tourist Tourist { get; set; }
    public Resort Resort { get; set; }
    public DateTime Arrival { get; set; }
    public int Days { get; set; }
    [Range(0.0, 99.0, ErrorMessage = "Wrong discount value")]
    public decimal Discount { get; set; }
}