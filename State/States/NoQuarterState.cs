using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using State.Abstractions;
using State.Machines;

namespace State.States
{
    public class NoQuarterState : IState
    {
        private readonly GumballMachine _gumballMachine;

        public NoQuarterState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void InjectQuarter()
        {
            Console.WriteLine("You inserted a quarter");
            _gumballMachine.State = _gumballMachine.GumballMachineHasQuarterState;
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You havn't inserted a quarter");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned, but there is no quarter");
        }

        public void Dispense()
        {
            Console.WriteLine("You need to pay first");
        }

        public override string ToString()
        {
            return "is Waiting for quarter";
        }
    }
}
