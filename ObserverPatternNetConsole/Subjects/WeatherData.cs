using System;
using System.Collections.Generic;

namespace ObserverPatternNetConsole
{
    public class WeatherData : IObservable<WeatherInfo>
    {
        public List<IObserver<WeatherInfo>> Observers { get; set; }
        private WeatherInfo weatherInfo;


        public WeatherData()
        {
            Observers = new List<IObserver<WeatherInfo>>();
        }

        public IDisposable Subscribe(IObserver<WeatherInfo> observer)
        {
            if (!Observers.Contains(observer))
                Observers.Add(observer);
            return new Unsubscriber(Observers, observer);
        }

        public void SetMeasurements(float temp, float humidity, float pressure)
        {
            weatherInfo = new WeatherInfo() { Temperature = temp, Humidity = humidity, Pressure = pressure };
            NotifyObservers(weatherInfo);
        }

        private void NotifyObservers(WeatherInfo weatherInfo)
        {
            foreach (var observer in Observers)
            {
                observer.OnNext(weatherInfo);
            }
        }
    }
}
