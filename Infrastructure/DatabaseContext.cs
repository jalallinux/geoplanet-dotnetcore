using GeoPlanet.App.Models;
using GeoPlanet.Database.Seeders;
using Microsoft.EntityFrameworkCore;

namespace GeoPlanet.Infrastructure;

public class DatabaseContext: DbContext
{
    public virtual DbSet<Country> Country { get; set; }
    
    public DatabaseContext(DbContextOptions options): base(options)
    { }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        new DatabaseSeeder(modelBuilder).Seed();
    }
}