using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command_Комады.Abstractions;
using Command_Комады.Device;

namespace Command_Комады.Commands
{
    public class StereoOnWithCDCommand : ICommand
    {
        private int previousVolume;

        private readonly Stereo stereo;

        public StereoOnWithCDCommand()
        {
        }

        public StereoOnWithCDCommand(Stereo stereo)
        {
            this.stereo = stereo;
            previousVolume = stereo.Volume;
        }

        public void Execute()
        {
            stereo.On();
            stereo.SetCD();
            stereo.Volume = 10;
        }

        public void Undo()
        {
            stereo.Volume = previousVolume;
            stereo.SetCD();
            stereo.Off();
        }
    }
}
