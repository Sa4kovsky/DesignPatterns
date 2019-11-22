using System;
using WeatherStation.Interface;

namespace WeatherStation.DisplayWetherData
{
    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        private float maxTemp = 0.0f;
        private float minTemp = 200;
        private float temperatureSum = 0.0f;
        private int numReadings = 0;
        private ISubject weatherData;

        public StatisticsDisplay(ISubject subject)
        {
            weatherData = subject;
            subject.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine ("Avg/Max/Min temperature = " + RoundFloatToString(temperatureSum / numReadings) + 
                "F/" + maxTemp + "F/" + minTemp + "F");
        }

        public void Update(float temp, float humidity, float pressure)
        {
            temperatureSum += temp;
            numReadings++;
            if (temp > maxTemp)
            {
                maxTemp = temp;
            }
            if (temp < minTemp)
            {
                minTemp = temp;
            }
            Display();
        }

        public static string RoundFloatToString(float floatToRound)
        {
            System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("en-US");
            cultureInfo.NumberFormat.CurrencyDecimalDigits = 2;
            cultureInfo.NumberFormat.CurrencyDecimalSeparator = ".";
            return floatToRound.ToString("F", cultureInfo);
        }
    }
}
