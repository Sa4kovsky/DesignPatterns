using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Заместитель.Abstractions
{
    public interface IState
    {
        void InjectQuarter();
        void EjectQuarter();
        void TurnCrank();
        void Dispense();
    }
}
