using Command_Комады.Abstractions;
using System;
//using System.Windows.Input;
using Command_Комады.Device;

namespace Command_Комады.Commands
{
    public class LightOnCommand : ICommand
    {
        Light light;

        public LightOnCommand(Light light)
        {
            this.light = light;
        }

        /*  public event EventHandler CanExecuteChanged;

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public void Execute(object parameter)
            {
                light.On();
            }*/

        public void Execute()
        {
            light.On();
        }

        public void Undo()
        {
            light.Off();
        }
    }
}
