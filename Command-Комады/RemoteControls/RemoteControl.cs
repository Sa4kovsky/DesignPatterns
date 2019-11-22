using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command_Комады.Abstractions;
using Command_Комады.Commands;
using Command_Комады.Device;

namespace Command_Комады.RemoteControls
{
    public class RemoteControl
    {
        private ICommand[] onCommands;
        private ICommand[] offCommands;
        private ICommand undoCommand;

        public RemoteControl()
        {
            onCommands = new ICommand[7];
            offCommands = new ICommand[7];

            ICommand noCommand = new NoCommand();
            for (int i = 0; i < onCommands.Length; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }

        }
        /*Метод получает ячейку  и комады вкл/выкл для этой ячейки. Команды save для послудующего использования
         * */
        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }

        public void OnButtonWasPressed(int slot)
        {
            onCommands[slot].Execute();
            undoCommand = onCommands[slot];
        }

        public void OffButtonWasPressed(int slot)
        {
            offCommands[slot].Execute();
            undoCommand = offCommands[slot];
        }

        public void UndoButtonWasPressed()
        {
            undoCommand.Undo();
        }

        public override string ToString()
        {
            var sb = new StringBuilder("\n------------Remote Control With Undo-----------\n");
            for (int i = 0; i < onCommands.Length; i++)
            {
                sb.Append($"[slot{i}] {onCommands[i].GetType()}\t{offCommands[i].GetType()} \n");
            }
            return sb.ToString();
        }

    }
}
