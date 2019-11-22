using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Фасад.Models
{
    public class PopcornPopper
    {
        public void On()
        {
            Console.WriteLine("Popcorn popper on");
        }

        public void Off()
        {
            Console.WriteLine("Popcorn popper off");
        }

        public void Pop()
        {
            Console.WriteLine("Popcorn popper popping popcorn");
        }
    }
}
