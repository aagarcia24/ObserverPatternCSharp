using System.Collections.Generic;

namespace ObserverPatternConsole
{
    public class WeatherData : Subject
    {
        public List<Observer> Observers { get; set; }
        public float Temperature { get; set; }
        public float Humidity { get; set; }
        public float Pressure { get; set; }

        public WeatherData()
        {
            Observers = new List<Observer>();
        }

        public void RegisterObserver(Observer o)
        {
            Observers.Add(o);
        }

        public void RemoveObserver(Observer o)
        {
            int i = Observers.IndexOf(o);
            if (i >= 0)
                Observers.RemoveAt(i);
        }

        public void NotifyObservers()
        {
            foreach (Observer observer in Observers)
                observer.Update(Temperature, Humidity, Pressure);
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;
            NotifyObservers();
        }
    }
}
