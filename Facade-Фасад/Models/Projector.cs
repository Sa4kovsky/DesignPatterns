using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Фасад.Models
{
    public class Projector
    {
        public void On()
        {
            Console.WriteLine("Projector on");
        }

        public void WideScreenMode()
        {
            Console.WriteLine("Project in widescreen mode");
        }

        public void Off()
        {
            Console.WriteLine("Projector off");
        }
    }
}
