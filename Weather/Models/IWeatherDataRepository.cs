using System;
namespace Weather.Models
{
    public interface IWeatherDataRepository
    {
        Weather GetWeatherData();
        Weather GetCityWeather(string city);
    }
}
