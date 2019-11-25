using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proxy_Заместитель.Machines;

namespace Proxy_Заместитель
{
    public class GumballMonitor
    {
        GumballMachine _gumballMachine;

        public GumballMonitor(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void report()
        {
            Console.WriteLine("Gumball Machine: " + _gumballMachine.Location);
            Console.WriteLine("Current inventoru " + _gumballMachine.Count + " gumballs");
            Console.WriteLine("Current State: " + _gumballMachine.State);
        }
    }
}
