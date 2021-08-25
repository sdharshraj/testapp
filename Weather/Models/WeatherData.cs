using System;
namespace Weather.Models
{
    public class WeatherData : IWeatherDataRepository
    {
        public Weather GetWeatherData()
        {
            return new Weather
            {
                Temperature = 37,
                Type = "Windy"
            };
        }

        public Weather GetCityWeather(string city)
        {
            switch (city)
            {
                case "Patna":
                    return new Weather
                    {
                        Temperature = 40,
                        Type = "Cloudy"
                    };

                case "Delhi":
                    return new Weather
                    {
                        Temperature = 45,
                        Type = "Windy and hot"
                    };
                default:
                    return new Weather
                    {
                        Temperature = 30,
                        Type = "No City selected"
                    };
            }
        }
    }
}