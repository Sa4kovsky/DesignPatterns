using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Duck_Стратегия.Model;
using Duck_Стратегия.Action.Fly;
using Duck_Стратегия.Action.Quack;

namespace Duck_Стратегия
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck duck = new MallardDuck();
            duck.Display();
            duck.PerformFly();
            duck.PerformQuack();

            Duck model = new DecoyDuck();
            model.Display();
            model.PerformFly();
            model.SetFlyBehavior(new FlyWithWings());
            model.PerformFly();

            Console.ReadLine();
        }
    }
}
