using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal class StatisticsDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float sumTemperature = 0;
        private float maxTemp = 0;
        private float minTemp = 0;
        private int countUpdated = 0;
        private Subject weatherData;
        public StatisticsDisplay(Subject weatherData) 
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
            // Set the field and register itself with the weatherdata subject
        }
        public void Update(float temp, float humidity, float pressure)
        {
            sumTemperature += temp;
            countUpdated++;

            if (temp > maxTemp)
                maxTemp = temp;

            if (temp < minTemp)
                minTemp = temp;
            // Set the correct fields with the relevant parameters
            Display();
        }

        public void Display()
        {
            float avgTemp = sumTemperature / countUpdated;
            Console.WriteLine($"Statistieken -> Gemiddeld: {avgTemp:0.0}°C | Max: {maxTemp:0.0}°C | Min: {minTemp:0.0}°C");
            // Print the average, maximum and minimum temperature. Use appropriate fields
        }
    }
}
