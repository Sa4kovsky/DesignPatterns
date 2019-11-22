using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Фасад.Models
{
    public class Amplifier
    {
        private int _volume;

        public void On()
        {
            Console.WriteLine("Amplifier is on");
        }

        public void SetDvd()
        {
            Console.WriteLine("Amplifier setting DVD palyer");
        }

        public void SetSurroundSound()
        {
            Console.WriteLine("Amplifier setting surround sound on");
        }

        public void SetVolume(int volume)
        {
            _volume = volume;
            Console.WriteLine($"Amplifier setting volume to {_volume}");
        }

        public void Off()
        {
            Console.WriteLine("Amplifier off");
        }
    }
}
