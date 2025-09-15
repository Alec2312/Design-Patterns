using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Displays
{
    internal class ForecastDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float humidity;
        private Subject weatherData;
        public ForecastDisplay(Subject weatherData) 
        { 
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
            // Set the field and register itself with the weatherdata subject
        }
        public void Update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            // Set the correct fields with the relevant parameters
            Display();
        }

        public void Display()
        {
            string message;

            if (temperature >= 25 && humidity < 60)
            {
                message = "Warm en zonnig! Perfect weer voor een terrasje.";
            }
            else if (temperature >= 20 && humidity >= 70)
            {
                message = "Lekker warm, maar neem een paraplu mee – kans op regen!";
            }
            else if (temperature < 10)
            {
                message = "Koud weer op komst, pak je jas en muts!";
            }
            else if (temperature < 15 && humidity > 80)
            {
                message = "Regenachtig en fris, trek je regenjas aan.";
            }
            else if (temperature >= 15 && temperature < 25 && humidity < 70)
            {
                message = "Aangenaam weer, ideaal voor een wandeling.";
            }
            else
            {
                message = "Het weer blijft wisselvallig – houd alles in de gaten.";
            }

            Console.WriteLine("Voorspelling: " + message);

            // Print a forecast message based on the current temperature and humidity
        }
    }
}
