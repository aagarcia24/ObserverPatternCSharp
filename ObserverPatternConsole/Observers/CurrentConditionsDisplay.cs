namespace ObserverPatternConsole
{
    public class CurrentConditionsDisplay : Observer, DisplayElement
    {
        public float Temperature { get; set; }
        public float Humidity { get; set; }
        public Subject WeatherData { get; set; }

        public CurrentConditionsDisplay(Subject weatherData)
        {
            WeatherData = weatherData;
            weatherData.RegisterObserver(this);
        }
        public void Update(float temp, float humidity, float pressure)
        {
            Temperature = temp;
            Humidity = humidity;
            Display();
        }
        public void Display()
        {
            System.Console.WriteLine($"Current conditions: {Temperature}F degrees and {Humidity}% humidity");
        }

    }
}
