using ObserverPatternHeadFirst.Interface;
using System;

namespace ObserverPatternHeadFirst
{
    public class WeatherData : Subject
    {
        private List<Observer> observers;
        private float temperature;
        private float humidity;
        private float pressure;
        public WeatherData()
        {
            observers = new List<Observer>();
        }
        public void registerObserver(Observer observer)
        {
            observers.Add(observer);
        }
        public void removeObserver(Observer observer)
        {
            observers.Remove(observer);
        }
        public void notifyObserver()
        {
            foreach (Observer observer in observers) 
            {
                observer.Update();
            }
        }
        public void measurementsChanged()
        {
            notifyObserver();
        }
        public void setMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            measurementsChanged();
        }
        public float GetTemperature()
        {
            return temperature;
        }

        public float GetHumidity()
        {
            return humidity;
        }

        public float GetPressure()
        {
            return pressure;
        }
    }
}
