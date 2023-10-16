using GeoPlanet.App.Models;
using GeoPlanet.Database.Seeders;
using Microsoft.EntityFrameworkCore;

namespace GeoPlanet.Infrastructure;

public class DatabaseContext: DbContext
{
    public virtual DbSet<Country> Country { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Host=127.0.0.1;Port=5432;Database=test;Username=postgres;Password=postgres;");
    
    public DatabaseContext(DbContextOptions options): base(options)
    {
        
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        new DatabaseSeeder(modelBuilder).Seed();
    }
    
}