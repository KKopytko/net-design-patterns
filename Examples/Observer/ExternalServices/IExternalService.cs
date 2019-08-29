namespace Patterns.Examples.Observer
{
    interface IExternalService
    {
        void Notify(WeatherState weatherState);
    }
}