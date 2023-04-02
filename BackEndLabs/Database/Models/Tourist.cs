using System.ComponentModel.DataAnnotations;

namespace BackEndLabs.Database.Models;

public class Tourist
{
    public int Id { get; set; }
    [MaxLength(30)]
    public string Name { get; set; }
    [MaxLength(40)]
    public string Surname { get; set; }
}