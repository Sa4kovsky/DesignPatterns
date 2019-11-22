using System;
using WeatherStation.Interface;

namespace WeatherStation.DisplayWetherData
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private float temperature;
        private float humidity;
        private ISubject weatheData;

        public CurrentConditionsDisplay(ISubject subject)
        {
            weatheData = subject;
            subject.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("Current conditions: " + temperature + "F degrees and " + humidity + "% humidity");
        }

        public void Update(float temp, float humidity, float pressure)
        {
            temperature = temp;
            this.humidity = humidity;
            Display();
        }
    }
}
