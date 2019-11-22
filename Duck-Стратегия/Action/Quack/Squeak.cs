﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duck_Стратегия.Action.Quack
{
    public class Squeak : IQuackBehavior
    {
        void IQuackBehavior.Quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}
