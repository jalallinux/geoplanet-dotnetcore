using GeoPlanet.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace GeoPlanet.Database.Seeders;

public class DatabaseSeeder: ISeeder
{
    protected readonly ModelBuilder _modelBuilder;

    public DatabaseSeeder(ModelBuilder modelBuilder)
    {
        _modelBuilder = modelBuilder;
    }

    public void Seed()
    {
        new CountrySeeder(_modelBuilder).Seed();
    }
}