using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using State.Machines;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            var originalColor = Console.ForegroundColor;

            var machine = new GumballMachine(5);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(machine);

            Console.ForegroundColor = originalColor;
            Console.WriteLine();
            machine.GumballMachineInjectQuarter();
            machine.GumballMachineTurnCrank();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(machine);

            Console.ForegroundColor = originalColor;
            Console.WriteLine();
            machine.GumballMachineInjectQuarter();
            machine.GumballMachineTurnCrank();
            machine.GumballMachineInjectQuarter();
            machine.GumballMachineTurnCrank();
            machine.GumballMachineInjectQuarter();
            machine.GumballMachineTurnCrank();
            machine.GumballMachineInjectQuarter();
            machine.GumballMachineTurnCrank();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(machine);

            Console.ReadLine();
        }
    }
}
