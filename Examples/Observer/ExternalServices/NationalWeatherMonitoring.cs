using System;

namespace Patterns.Examples.Observer
{
    class NationalWeatherMonitoring : IExternalService
    {
        public void Notify(WeatherState weatherState)
        {
            Console.WriteLine($"{GetType().Name} received {weatherState}");
        }
    }
}