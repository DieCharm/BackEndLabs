using BackEndLabs.Database;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddMvc();
builder.Services.AddDbContext<TourDbContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("Tours")));

var app = builder.Build();

app.UseHttpsRedirection();
app.UseRouting();
app.UseStaticFiles();

app.UseEndpoints(e => 
    e.MapRazorPages());

app.Run();