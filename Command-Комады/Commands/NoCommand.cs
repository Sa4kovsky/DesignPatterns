using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command_Комады.Abstractions;

namespace Command_Комады.Commands
{
    public class NoCommand : ICommand
    {
        public void Execute()
        {
        }

        public void Undo()
        {
        }
    }
}
