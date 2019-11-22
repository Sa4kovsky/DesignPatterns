using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Duck_Стратегия.Action.Fly;
using Duck_Стратегия.Action.Quack;

namespace Duck_Стратегия.Model
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("I am a real Mallard duck");
        }
    }
}
