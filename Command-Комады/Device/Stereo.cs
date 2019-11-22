﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Комады.Device
{
    public class Stereo
    {

        public Stereo()
        {
            Volume = 5;
        }

        public void On()
        {
            System.Console.WriteLine("Stereo is on.");
        }

        public void Off()
        {
            System.Console.WriteLine("Stereo is off.");
        }

        public void SetCD()
        {
            System.Console.WriteLine("Stereo is set for CD input.");
        }

        private int volume;
        public int Volume
        {
            get { return volume; }
            set
            {
                volume = value;
                System.Console.WriteLine($"Stereo's volume is set to {volume}");
            }
        }

    }
}
