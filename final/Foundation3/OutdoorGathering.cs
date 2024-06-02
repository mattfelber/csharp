public class OutdoorGathering : Event
{
    private string weatherForecast;

    public OutdoorGathering(string title, string description, DateTime date, string time, Address address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        this.weatherForecast = weatherForecast;
    }

    public string WeatherForecast { get { return weatherForecast; } }

    public override string GetFullDetails()
    {
        return base.GetFullDetails() + $"\nWeather Forecast: {weatherForecast}";
    }
}
