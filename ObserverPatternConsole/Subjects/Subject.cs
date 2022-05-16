namespace ObserverPatternConsole
{
    public interface Subject
    {
        public void RegisterObserver(Observer o);

        public void RemoveObserver(Observer o);

        public void NotifyObservers();
    }
}
