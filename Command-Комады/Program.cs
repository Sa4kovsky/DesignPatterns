using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command_Комады.Abstractions;
using Command_Комады.Commands;
using Command_Комады.Device;
using Command_Комады.RemoteControls;

namespace Command_Комады
{
    class Program
    {
        static void Main(string[] args)
        { 
            //RunSimpleRemoteControl(); 
            //RunRemoteControl(); // ПРОСТО ПАТТЕРН КОМАНДЫ
            //RunRemoteControlWithUndo(); // КНОПКА ОТМЕНЫ 
            RunRemoteControlWithMacroCommand(); // НА ОДНУ КНОПКУ ПУЛЬТА НЕСКОЛЬКО КОМАНД
            Console.ReadLine();
        }

        public static void RunRemoteControlWithMacroCommand()
        {
            var light = new Light();
            var lightOn = new LightOnCommand(light);
            var lightOff = new LightOffCommand(light);
            var garageDoor = new GarageDoor();
            var garageDoorOpen = new GarageDoorOpenCommand(garageDoor);
            var garageDoorClose = new GarageDoorCloseCommand(garageDoor);
            var stereo = new Stereo();
            var stereoOnWithCD = new StereoOnWithCDCommand(stereo);
            var stereoOff = new StereoOffCommand(stereo);

            var macroOnCommand = new MacroCommand(new ICommand[] { lightOn, garageDoorOpen, stereoOnWithCD });
            var macroOffCommand = new MacroCommand(new ICommand[] { lightOff, garageDoorClose, stereoOff });

            var remote = new RemoteControl();
            remote.SetCommand(0, macroOnCommand, macroOffCommand);
            System.Console.WriteLine(remote);

            System.Console.WriteLine("--- Pushing Macro on ---");
            remote.OnButtonWasPressed(0);
            System.Console.WriteLine("--- Pushing Macro off ---");
            remote.OffButtonWasPressed(0);
        }

        public static void RunRemoteControlWithUndo()
        {
            var remote = new RemoteControlWithUndo();
            var light = new Light();
            var lightOn = new LightOnCommand(light);
            var lightOff = new LightOffCommand(light);
            var stereo = new Stereo();
            var stereoOnWithCD = new StereoOnWithCDCommand(stereo);
            var stereoOff = new StereoOffCommand(stereo);

            remote.SetCommand(0, lightOn, lightOff);
            remote.SetCommand(1, stereoOnWithCD, stereoOff);
            System.Console.WriteLine(remote);

            remote.OnButtonWasPressed(0);
            remote.OffButtonWasPressed(0);
            remote.UndoButtonWasPressed();

            remote.OnButtonWasPressed(1);
            remote.UndoButtonWasPressed();
            remote.OffButtonWasPressed(1);
        }

        public static void RunRemoteControl()
        {
            var remote = new RemoteControl();
            var light = new Light();
            var lightOn = new LightOnCommand(light);
            var lightOff = new LightOffCommand(light);
            var garageDoor = new GarageDoor();
            var garageDoorOpen = new GarageDoorOpenCommand(garageDoor);
            var garageDoorClose = new GarageDoorCloseCommand(garageDoor);
            var stereo = new Stereo();
            var stereoOnWithCD = new StereoOnWithCDCommand(stereo);
            var stereoOff = new StereoOffCommand(stereo);

            remote.SetCommand(0, lightOn, lightOff);
            remote.SetCommand(1, garageDoorOpen, garageDoorClose);
            remote.SetCommand(2, stereoOnWithCD, stereoOff);

            System.Console.WriteLine(remote);

            remote.OnButtonWasPressed(0);
            remote.OffButtonWasPressed(0);
            remote.OnButtonWasPressed(1);
            remote.OffButtonWasPressed(1);
            remote.OnButtonWasPressed(2);
            remote.OffButtonWasPressed(2);
        }

        /*   public static void RunSimpleRemoteControl()
           {
               SimpleRemoteControl remote = new SimpleRemoteControl();
               Light light = new Light();
               LightOnCommand lightOn = new LightOnCommand(light);

               remote.Slot = (lightOn);
               remote.ButtonWasPressed();

               var garageDoor = new GarageDoor();
               var garageDoorOpen = new GarageDoorOpenCommand(garageDoor); 

               remote.Slot = garageDoorOpen;
               remote.ButtonWasPressed();
           }*/
    }
}
