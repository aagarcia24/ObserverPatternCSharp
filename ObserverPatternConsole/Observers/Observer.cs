namespace ObserverPatternConsole
{
    public interface Observer
    {
        public void Update(float temp, float humidity, float pressure);
    }
}
