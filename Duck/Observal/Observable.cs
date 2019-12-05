using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Duck.Abstract;

namespace Duck.Observal
{
    public class Observable : IQuackObservable
    {
        private readonly List<IObserver> _observers = new List<IObserver>();
        private readonly IQuackObservable _duck;

        public Observable(IQuackObservable duck)
        {
            _duck = duck;
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void NotifyObservers()
        {
            using (var enumerator = _observers.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    var observer = enumerator.Current;
                    observer.Update(_duck);
                }
            }
        }
    }
}

