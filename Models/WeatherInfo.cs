namespace lr9api.Models
{
    public class WeatherInfo
    {
        public Main Main { get; set; }
        public Weather[] Weather { get; set; }
        public string Name { get; set; }
        public Wind Wind { get; set; }

        public int Visibility { get; set; } // Видимість в метрах
    }

    public class Main
    {
        public double Temp { get; set; }
        public double Pressure { get; set; }
        public double Humidity { get; set; }
        public double Feels_like { get; set; } // Температура, яку відчуває людина
    }

    public class Weather
    {
        public string Description { get; set; }
    }

    public class Wind
    {
        public double Speed { get; set; }
        public double Deg { get; set; } // Напрямок вітру
    }
}
