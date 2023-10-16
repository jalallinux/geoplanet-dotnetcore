using GeoPlanet.App.Models;
using Microsoft.EntityFrameworkCore;

namespace GeoPlanet.Database.Seeders;

public class CountrySeeder: DatabaseSeeder
{
    public CountrySeeder(ModelBuilder modelBuilder) : base(modelBuilder)
    {
    }

    public void Seed()
    {
        _modelBuilder.Entity<Country>().HasData(
            new Country(103, "Iran", "Tehran", "IRR", "IR", "Southern Asia", "Asia/Tehran", "U+1F1EE U+1F1F7")
        );
    }
}