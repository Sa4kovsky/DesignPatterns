using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adapter_Адаптер.Model.Interface;

namespace Adapter_Адаптер.Model
{
    public class Duck : IDuck
    {
        public void Fly()
        {
            Console.WriteLine("Fly");
        }

        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
