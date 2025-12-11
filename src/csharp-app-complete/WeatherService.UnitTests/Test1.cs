using System.Net;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc.Testing;
using CSharpApp.Models;

namespace WeatherService.UnitTests;

[TestClass]
public class WeatherApiTests
{
    private WebApplicationFactory<Program>? _factory;
    private HttpClient? _client;

    [TestInitialize]
    public void Setup()
    {
        _factory = new WebApplicationFactory<Program>();
        _client = _factory.CreateClient();
    }

    [TestCleanup]
    public void Cleanup()
    {
        _client?.Dispose();
        _factory?.Dispose();
    }

    [TestMethod]
    public async Task TestRoot_ReturnsRedirect()
    {
        // Arrange
        var clientOptions = new WebApplicationFactoryClientOptions
        {
            AllowAutoRedirect = false
        };
        var client = _factory!.CreateClient(clientOptions);
        
        // Act
        var response = await client.GetAsync("/");

        // Assert
        Assert.IsTrue(
            response.StatusCode == HttpStatusCode.MovedPermanently || 
            response.StatusCode == HttpStatusCode.Redirect,
            $"Expected redirect status code, but got {response.StatusCode}");
        Assert.IsTrue(response.Headers.Location?.ToString().Contains("swagger") ?? false);
    }

    [TestMethod]
    public async Task TestCountries_ReturnsCorrectList()
    {
        // Arrange & Act
        var response = await _client!.GetAsync("/countries");
        
        // Assert
        Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        
        var content = await response.Content.ReadAsStringAsync();
        var countries = JsonSerializer.Deserialize<List<string>>(content);
        
        Assert.IsNotNull(countries);
        Assert.AreEqual(7, countries.Count);
        
        var sortedCountries = countries.OrderBy(c => c).ToList();
        var expectedCountries = new List<string> 
        { 
            "England", "France", "Germany", "Italy", "Peru", "Portugal", "Spain" 
        };
        
        CollectionAssert.AreEqual(expectedCountries, sortedCountries);
    }

    [TestMethod]
    public async Task TestMonthlyAverage_LondonJanuary_ReturnsCorrectData()
    {
        // Arrange & Act
        var response = await _client!.GetAsync("/countries/England/London/January");
        
        // Assert
        Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        
        var content = await response.Content.ReadAsStringAsync();
        var weatherData = JsonSerializer.Deserialize<TemperatureDto>(content, 
            new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        
        Assert.IsNotNull(weatherData);
        Assert.AreEqual(45, weatherData.High);
        Assert.AreEqual(36, weatherData.Low);
    }

    [TestMethod]
    public async Task TestMonthlyAverage_InvalidCountry_ReturnsNotFound()
    {
        // Arrange & Act
        var response = await _client!.GetAsync("/countries/InvalidCountry/SomeCity/January");
        
        // Assert
        Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);
    }

    [TestMethod]
    public async Task TestMonthlyAverage_InvalidCity_ReturnsNotFound()
    {
        // Arrange & Act
        var response = await _client!.GetAsync("/countries/England/InvalidCity/January");
        
        // Assert
        Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);
    }

    [TestMethod]
    public async Task TestMonthlyAverage_InvalidMonth_ReturnsNotFound()
    {
        // Arrange & Act
        var response = await _client!.GetAsync("/countries/England/London/InvalidMonth");
        
        // Assert
        Assert.AreEqual(HttpStatusCode.NotFound, response.StatusCode);
    }
}
