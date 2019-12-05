using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Duck.Abstract;
using Duck.Observal;

namespace Duck.Models
{
    public class RedheadDuck : IQuackable
    {
        Observable _observable;

        public RedheadDuck()
        {
            _observable = new Observable(this);
        }


        public void Quack()
        {
            Console.WriteLine("Quack");
        }

        public void RegisterObserver(IObserver observer)
        {
            _observable.RegisterObserver(observer);
        }

        public void NotifyObservers()
        {
            _observable.NotifyObservers();
        }
    }
}
