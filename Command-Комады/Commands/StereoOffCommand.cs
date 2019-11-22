using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command_Комады.Abstractions;
using Command_Комады.Device;

namespace Command_Комады.Commands
{
    public class StereoOffCommand : ICommand
    {
        private readonly Stereo stereo;

        public StereoOffCommand(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            stereo.Off();
        }

        public void Undo()
        {
            stereo.On();
        }
    }
}
