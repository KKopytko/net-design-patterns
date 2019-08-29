namespace Patterns.Examples.Observer
{
    class WeatherState
    {
        public double Temperature { get; private set; }
        public double Humidity { get; private set; }
        public string WindDirection { get; private set; }

        public WeatherState(double temperature, double humidity, string windDirection)
        {
            Temperature = temperature;
            Humidity = humidity;
            WindDirection = windDirection;
        }

        public override string ToString()
        {
            return $"Temp: {Temperature}, Humid: {Humidity}, Wind: {WindDirection}";
        }

        public override bool Equals(object obj)
        {
            var objCasted = obj as WeatherState;
            if (objCasted == null)
            {
                return false;
            }

            return this.GetHashCode() == objCasted.GetHashCode();
        }

        public override int GetHashCode()
        {
            return Temperature.GetHashCode() ^ Humidity.GetHashCode() ^ WindDirection.GetHashCode();
        }
    }
}