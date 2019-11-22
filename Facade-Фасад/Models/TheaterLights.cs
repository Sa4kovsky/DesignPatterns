using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Фасад.Models
{
    public class TheaterLights
    {
        private int _brightness;

        public void Dim(int brightness)
        {
            _brightness = brightness;
            Console.WriteLine($"Theater lights dimming on {_brightness}");
        }

        public void On()
        {
            _brightness = 10;
            Console.WriteLine("Theater lights on");
        }
    }
}
