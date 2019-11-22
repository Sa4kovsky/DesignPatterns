using System;
using System.Text;
using WeatherStation.Interface;

namespace WeatherStation.DisplayWetherData
{
    public class ForcastDisplay : IObserver, IDisplayElement
    {
        private float currentPressure = 29.92f;
        private float lastPressure;
        private ISubject weatherData;

        public ForcastDisplay(ISubject subject)
        {
            this.weatherData = subject;
            subject.RegisterObserver(this);
        }

        public void Display()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Forecast: ");
            if (currentPressure > lastPressure)
            {
                sb.Append("Improving weather on the way!");
            }
            else if (currentPressure == lastPressure)
            {
                sb.Append("More of the same");
            }
            else if (currentPressure < lastPressure)
            {
                sb.Append("Watch out for cooler, rainy weather");
            }
            Console.WriteLine(sb.ToString());
        }

        public void Update(float temp, float humidity, float pressure)
        {
            lastPressure = currentPressure;
            currentPressure = pressure;
            Display();
        }
    }
}
