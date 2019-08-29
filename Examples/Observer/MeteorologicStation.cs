namespace Patterns.Examples.Observer
{
    delegate void WeatherChange(WeatherState weatherState);

    abstract class MeteorologicStation
    {
        public double Latitude { get; private set; }
        public double Longitude { get; private set; }
        public string Name { get; private set; }

        private WeatherState weatherState;
        public WeatherState WeatherState
        {
            get { return weatherState; }
            set
            { 
                if (weatherState == null || !weatherState.Equals(value))
                {
                    weatherState = value;
                    OnWeatherChanged(weatherState);
                }
            }
        }

        private event WeatherChange OnWeatherChanged;

        public MeteorologicStation(string name, double latitude, double longitude)
        {
            Name = name;
            Latitude = latitude;
            Longitude = longitude;
        }

        public void Attach(IExternalService externalService)
        {
            OnWeatherChanged += externalService.Notify;
        }

        public void Detatch(IExternalService externalService)
        {
            OnWeatherChanged -= externalService.Notify;
        }
    }
}