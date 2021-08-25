using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Weather.Models;

namespace Weather.Controllers
{
    public class WeatherController : Controller     
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWeatherDataRepository _weatherDataRepository;

        public WeatherController(ILogger<HomeController> logger, IWeatherDataRepository weatherDataRepository)
        {
            _logger = logger;
            _weatherDataRepository = weatherDataRepository;
        }

        public IActionResult Index()
        {
            var weather = _weatherDataRepository.GetWeatherData();

            ViewData["WeatherData"] = weather;
            ViewData["PageTitle"] = "Weather information";

            return View();
        }

        [HttpPost]
        public EmptyResult YourMethod(string txtValue)
        {
            Models.Weather weather = _weatherDataRepository.GetCityWeather(txtValue);

            ViewData["WeatherData"] = weather;
            ViewData["PageTitle"] = "Weather information";

            return new EmptyResult();
        }

    }
}
