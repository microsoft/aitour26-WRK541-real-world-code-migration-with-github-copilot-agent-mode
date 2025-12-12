using CSharpApp.Services;
using CSharpApp.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WeatherServiceUnitTests;

[TestClass]
public class WeatherServiceTests
{
    [TestMethod]
    public void GetCountries_ReturnsEngland()
    {
        var svc = new WeatherService();
        var list = svc.GetCountries().ToList();
        CollectionAssert.Contains(list, "England");
    }

    [TestMethod]
    public void TryGetMonthlyAverage_LondonJanuary_ReturnsCorrectData()
    {
        var svc = new WeatherService();
        var ok = svc.TryGetMonthlyAverage("England", "London", "January", out TemperatureDto? dto);
        Assert.IsTrue(ok);
        Assert.IsNotNull(dto);
        Assert.AreEqual(45, dto!.High);
        Assert.AreEqual(36, dto.Low);
    }

    [TestMethod]
    public void TryGetMonthlyAverage_InvalidCountry_ReturnsFalse()
    {
        var svc = new WeatherService();
        var ok = svc.TryGetMonthlyAverage("InvalidCountry", "SomeCity", "January", out TemperatureDto? dto);
        Assert.IsFalse(ok);
        Assert.IsNull(dto);
    }
}
