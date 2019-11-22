using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adapter_Адаптер.Model.Interface;

namespace Adapter_Адаптер.Model
{
    public class Turkey : ITurkey
    {
        public void Fly()
        {
            Console.WriteLine("Flying a short");
        }

        public void Gobble()
        {
            Console.WriteLine("Gobble Gobble");
        }
    }
}
