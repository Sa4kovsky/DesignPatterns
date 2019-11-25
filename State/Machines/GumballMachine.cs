using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using State.Abstractions;
using State.States;

namespace State.Machines
{
    public class GumballMachine
    {
        public IState GumballMachineSoldOutState { get; set; }
        public IState GumballMachineNoQuarterState { get; set; }
        public IState GumballMachineHasQuarterState { get; set; }
        public IState GumballMachineSoldState { get; set; }
        public IState GumballMachineWinnerState { get; set; }
        public IState State { get; set; }
        public int Count { get; set; }

        public GumballMachine(int numberOfGumballs)
        {
            GumballMachineSoldState = new SoldState(this);
            GumballMachineNoQuarterState = new NoQuarterState(this);
            GumballMachineHasQuarterState = new HasQuarterState(this);
            GumballMachineSoldOutState = new SoldOutState(this);
            GumballMachineWinnerState = new WinnerState(this);

            Count = numberOfGumballs;
            if (Count > 0)
            {
                State = GumballMachineNoQuarterState;
            }
        }

        public void GumballMachineInjectQuarter()
        {
            State.InjectQuarter();
        }

        public void GumballMachineEjectQuarter()
        {
            State.EjectQuarter();
        }

        public void GumballMachineTurnCrank()
        {
            State.TurnCrank();
            State.Dispense();
        }

        public void GumballMachineReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");
            if (Count != 0)
            {
                Count--;
            }
        }

        public void GumballMachineRefill(int count)
        {
            Count += count;
            State = GumballMachineNoQuarterState;
        }

        public override string ToString()
        {
            return $"Mighty Gumball, Inc.\nC#-enabled Standing Gumball Model #2019\nInventory: {Count} gumballs\nThe machine {State} ";
        }
    }
}
