namespace Patterns.Examples.Observer
{
    public class ObserverExample : IRunnableExample
    {
        public string Name => "Observer";

        public void Run()
        {
            var station = new RoofStation("SR1WXZ", 5327.37, 1432.46);

            station.Attach(new ForecastTelevision());
            station.Attach(new NationalWeatherMonitoring());

            station.WeatherState = new WeatherState(15.0, 25.1, "NE");
            station.WeatherState = new WeatherState(16.0, 25.1, "NE");
            station.WeatherState = new WeatherState(16.0, 25.1, "NE");
            station.WeatherState = new WeatherState(17.5, 25.1, "SW");
        }
    }
}