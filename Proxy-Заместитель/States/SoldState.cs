using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proxy_Заместитель.Abstractions;
using Proxy_Заместитель.Machines;

namespace Proxy_Заместитель.States
{
    public class SoldState : IState
    {
        private readonly GumballMachine _gumballMachine;

        public SoldState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void InjectQuarter()
        {
            Console.WriteLine("Please wait, we’re already giving you a gumball");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Sorry, you already turned the crank");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Turning twice doesn’t get you another gumball!");
        }

        public void Dispense()
        {
            _gumballMachine.GumballMachineReleaseBall();
            if (_gumballMachine.Count > 0)
            {
                _gumballMachine.State = _gumballMachine.GumballMachineNoQuarterState;
            }
            else
            {
                Console.WriteLine("Oops, out of gumballs!");
                _gumballMachine.State = _gumballMachine.GumballMachineSoldOutState;
            }
        }

        public override string ToString()
        {
            return "just sold a gumball";
        }
    }
}
