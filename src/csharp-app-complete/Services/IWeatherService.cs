using System.Collections.Generic;
using CSharpApp.Models;

namespace CSharpApp.Services
{
    public interface IWeatherService
    {
        IEnumerable<string> GetCountries();
        bool TryGetMonthlyAverage(string country, string city, string month, out TemperatureDto? dto);
    }
}
