using ObserverPatternHeadFirst.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternHeadFirst
{
    public class CurrentConditionsDisplay:Observer,DisplayElement
    {
        private float temperature;
        private float humidity;
        private WeatherData weatherData;

        public CurrentConditionsDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }

        public void Update()
        {
            this.temperature = weatherData.GetTemperature();
            this.humidity = weatherData.GetHumidity();
            display();
        }

        public void display()
        {
            Console.WriteLine("Current conditions: " + temperature
            + "F degrees and " + humidity + "% humidity");
        }
    }
}
