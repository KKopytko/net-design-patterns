using System;

namespace Patterns.Examples.Observer
{
    class ForecastTelevision : IExternalService
    {
        public void Notify(WeatherState weatherState)
        {
            Console.WriteLine($"{GetType().Name} received {weatherState}");
        }
    }
}