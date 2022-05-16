using System;

namespace ObserverPatternNetConsole
{
    public class CurrentConditionsDisplay : IObserver<WeatherInfo>, DisplayElement
    {
        private WeatherInfo weatherInfo;
        public IDisposable Unsubscriber { get; set; }
        public void Display()
        {
            Console.WriteLine($"Current conditions: {weatherInfo.Temperature}F degrees and {weatherInfo.Humidity}% humidity");
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(WeatherInfo value)
        {
            weatherInfo = value;
            Display();
        }
    }
}
