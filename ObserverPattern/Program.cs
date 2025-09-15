using ObserverPattern.Displays;

namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();
            CurrentConditionDisplay currentCondition = new CurrentConditionDisplay(weatherData);
            ForecastDisplay forecast = new ForecastDisplay(weatherData);
            StatisticsDisplay statistics = new StatisticsDisplay(weatherData);

            // Create instances of displays 
            weatherData.RemoveObserver(statistics);
            weatherData.SetMeasurements(28, 65, 30.4f);
            weatherData.SetMeasurements(29, 70, 29.2f);
            weatherData.SetMeasurements(30, 90, 29.2f);
            Console.ReadLine();
        }
    }
}