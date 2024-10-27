using Microsoft.AspNetCore.Mvc;
using lr9api.Models;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace lr9api.Controllers
{
    public class WeatherController : Controller
    {
        private readonly HttpClient _httpClient;

        public WeatherController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IActionResult> CurrentWeather(string region, string customRegion)
        {
            var apiKey = "982efe3c1da11e22a3f773eeb221e809";
            // Використовуємо customRegion, якщо воно не пусте, інакше використовуємо region
            var city = !string.IsNullOrEmpty(customRegion) ? customRegion : region;

            if (string.IsNullOrEmpty(city))
            {
                return BadRequest("Не вказано місто.");
            }

            var url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric";

            try
            {
                var response = await _httpClient.GetStringAsync(url);
                var weatherInfo = JsonConvert.DeserializeObject<WeatherInfo>(response);
                return View(weatherInfo);
            }
            catch (HttpRequestException e)
            {
           
                return BadRequest("Не вдалося отримати дані про погоду: " + e.Message);
            }
        }
    }
}
