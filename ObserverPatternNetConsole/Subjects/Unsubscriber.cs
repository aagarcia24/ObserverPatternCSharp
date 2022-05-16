using System;
using System.Collections.Generic;

namespace ObserverPatternNetConsole
{
    public class Unsubscriber : IDisposable
    {
        private List<IObserver<WeatherInfo>> _observers;
        private IObserver<WeatherInfo> _observer;

        public Unsubscriber(List<IObserver<WeatherInfo>> observers, IObserver<WeatherInfo> observer)
        {
            this._observers = observers;
            this._observer = observer;
        }

        public void Dispose()
        {
            if (_observer != null && _observers.Contains(_observer))
                _observers.Remove(_observer);
        }
    }
}
