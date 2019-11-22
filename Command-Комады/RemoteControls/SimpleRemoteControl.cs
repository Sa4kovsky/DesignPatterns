using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Command_Комады.RemoteControls
{
    class SimpleRemoteControl
    {
        public ICommand Slot { get; set; }

        public SimpleRemoteControl()
        {

        }

        public void ButtonWasPressed()
        {
            Slot.Execute(null);
        }
    }
}
