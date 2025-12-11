using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using CSharpApp.Models;

namespace CSharpApp.Services
{
    public class WeatherService : IWeatherService
    {
        private readonly Dictionary<string, Dictionary<string, Dictionary<string, TemperatureDto>>> _data;

        public WeatherService()
        {
            var path = Path.Combine(AppContext.BaseDirectory, "weather.json");
            if (!File.Exists(path))
            {
                _data = new Dictionary<string, Dictionary<string, Dictionary<string, TemperatureDto>>>();
                return;
            }

            var json = File.ReadAllText(path);
            var opts = new JsonSerializerOptions(JsonSerializerDefaults.Web);
            _data = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, Dictionary<string, TemperatureDto>>>>(json, opts)
                    ?? new Dictionary<string, Dictionary<string, Dictionary<string, TemperatureDto>>>();
        }

        public IEnumerable<string> GetCountries()
        {
            return _data.Keys;
        }

        public bool TryGetMonthlyAverage(string country, string city, string month, out TemperatureDto? dto)
        {
            dto = null;
            if (country is null || city is null || month is null) return false;

            if (!_data.TryGetValue(country, out var cities)) return false;
            if (!cities.TryGetValue(city, out var months)) return false;
            if (!months.TryGetValue(month, out var temp)) return false;

            dto = temp;
            return true;
        }
    }
}
