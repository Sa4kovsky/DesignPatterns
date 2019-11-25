using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using State.Abstractions;
using State.Machines;

namespace State.States
{
    public class HasQuarterState : IState
    {
        private readonly GumballMachine _gumballMachine;
        private readonly Random _random = new Random();

        public HasQuarterState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void InjectQuarter()
        {
            Console.WriteLine("You can’t insert another quarter");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Quarter returned");
            _gumballMachine.State = _gumballMachine.GumballMachineNoQuarterState;
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned...");
            var winner = _random.Next(0, 10);
            if (winner == 0 && _gumballMachine.Count > 1)
            {
                _gumballMachine.State = _gumballMachine.GumballMachineWinnerState;
            }
            else
            {
                _gumballMachine.State = _gumballMachine.GumballMachineSoldState;
            }
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }

        public override string ToString()
        {
            return "just being inserted with a quarter";
        }
    }
}
