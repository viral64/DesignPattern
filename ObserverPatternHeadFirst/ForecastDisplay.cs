using ObserverPatternHeadFirst.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternHeadFirst
{
    public class ForecastDisplay:Observer,DisplayElement
    {
        private float currentPressure = 29.2f;
        private float lastPressure;
        private WeatherData weatherData;
        public ForecastDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }
        public void Update()
        {
            lastPressure = currentPressure;
            currentPressure=weatherData.GetPressure();
            display();
        }
        public void display()
        {
            Console.WriteLine("ForecastDisplay "+lastPressure + " " + currentPressure);
        }
    }
}
