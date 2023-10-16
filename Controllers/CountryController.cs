using System.Text.Json;
using Microsoft.AspNetCore.Mvc;

namespace GeoPlanet.Controllers;

[Route("api/[controller]")]
public class CountryController : ControllerBase
{
    private List<string> Urls = new List<string>
    {
        "https://raw.githubusercontent.com/dr5hn/countries-states-cities-database/master/countries.json",
        "https://raw.githubusercontent.com/dr5hn/countries-states-cities-database/master/states.json",
        "https://raw.githubusercontent.com/dr5hn/countries-states-cities-database/master/cities.json"
    };
    
    [HttpGet(Name = "country")]
    public async void Get()
    {
        var countries = JsonSerializer.Deserialize<List<object>>(await new HttpClient().GetStringAsync(Urls[0]));

        
    }
}