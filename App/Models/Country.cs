using System.ComponentModel.DataAnnotations;

namespace GeoPlanet.App.Models;

public class Country
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Capital { get; set; }
    public string Currency { get; set; }
    public string SubRegion { get; set; }
    public string TimeZone { get; set; }
    public string Flag { get; set; }
    public string Iso2 { get; set; }
        
    public Country(int id, string name, string capital, string currency,
        string iso2, string subRegion, string timeZone, string flag)
    {
        Id = id;
        Name = name;
        Capital = capital;
        Currency = currency;
        Iso2 = iso2;
        SubRegion = subRegion;
        TimeZone = timeZone;
        Flag = flag;
    }
}