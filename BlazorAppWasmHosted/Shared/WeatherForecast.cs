namespace BlazorAppWasmHosted.Shared
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public string? Summary { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }

    public class PostModel
    {
        public int id { get; set; }

        public int userId { get; set; }

        public string? title { get; set; }

        public string body { get; set; }
    }
}