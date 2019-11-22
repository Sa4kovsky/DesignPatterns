using Duck_Стратегия.Action.Fly;
using Duck_Стратегия.Action.Quack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duck_Стратегия.Model
{
    public abstract class Duck
    { 
        protected IFlyBehavior flyBehavior;
        protected IQuackBehavior quackBehavior;

        public abstract void Display();

        public void PerformFly()
        {
            flyBehavior.Fly();
        }

        public void PerformQuack()
        {
            quackBehavior.Quack();
        }

        public void SetFlyBehavior(IFlyBehavior fly)
        {
            flyBehavior = fly;
        }

        public void SetQuackBehavior(IQuackBehavior quack)
        {
            quackBehavior = quack;
        }
    }
}
