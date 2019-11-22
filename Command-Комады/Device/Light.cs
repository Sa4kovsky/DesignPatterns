using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Комады.Device
{
    public class Light
    {
        public void On()
        {
            Console.WriteLine("Light is on");
        }

        public void Off()
        {
            Console.WriteLine("Light is off");
        }
    }
}
