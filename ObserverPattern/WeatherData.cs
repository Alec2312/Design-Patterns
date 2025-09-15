using ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    internal class WeatherData : Subject
    {
        private List<Observer> observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observers = new List<Observer>();
        }
        // instance variables
        public void NotifyObservers()
        {
            foreach (Observer observer in observers)
            {
                observer.Update(temperature, humidity, pressure);
            }
            // Loop through the observers and call Update() with the appropriate fields
        }

        public void RegisterObserver(Observer o)
        {
            if (!observers.Contains(o)) {
                observers.Add(o);
            }
            // Check if observer is not already subscribed, if not then add to the list of observers
        }

        public void RemoveObserver(Observer o)
        {
            if (observers.Contains(o))
            {
                observers.Remove(o);
            }
            // Check if observer is subscribed, if they are then remove from the list of observers
           
        }

        public void MeasurementChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float tempereature, float humidity, float pressure)
        {
            this.temperature = tempereature;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasurementChanged();
        }
    }
}
