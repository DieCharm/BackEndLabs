using BackEndLabs.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace BackEndLabs.Database;

public class TourDbContext: DbContext
{
    public TourDbContext(DbContextOptions<TourDbContext> options) : base(options)
    { }
    
    public DbSet<Resort> Resorts { get; set; }
    public DbSet<Tourist> Tourists { get; set; }
    public DbSet<Reservation> Reservations { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Reservation>()
            .HasKey(reservation => new
            {
                reservation.ResortId, 
                reservation.TouristId
            });
    }
    
    /*public TourDbContext()
    { }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=JACKFLASHPC;Database=ToursDatabase;Trusted_Connection=True;");
    }*/
}