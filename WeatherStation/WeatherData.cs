using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStation.Interface;

namespace WeatherStation
{
    public class WeatherData : ISubject
    {
        private ArrayList observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observers = new ArrayList();
        }

        #region realization ISubject

        public void NotifyObserver()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(temperature, humidity, pressure);
            }
        }

        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            int deleteObserver = observers.IndexOf(o);
            if (deleteObserver >= 0)
            {
                observers.Remove(deleteObserver);
            }
        }
        #endregion

        //Оповещение наблюдателей
        private void MeasurementsChanged()
        {
            NotifyObserver();
        }
 
        public void SetMeasurements(float temperature, float humidity,float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasurementsChanged();
        }
    }
}
