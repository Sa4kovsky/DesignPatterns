using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command_Комады.Abstractions;
using Command_Комады.Device;

namespace Command_Комады.Commands
{
    public class GarageDoorCloseCommand : ICommand
    {
        private readonly GarageDoor garageDoor;

        public GarageDoorCloseCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }

        public void Execute()
        {
            garageDoor.Down();
        }

        public void Undo()
        {
            garageDoor.Up();
        }
    }
}
