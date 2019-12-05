using System;
using System.Collections;
using System.Collections.Generic;
using Duck.Abstract;
using Duck.Observal;

namespace Duck.Models
{
    // Утиная стая
    public class DuckFlock : IQuackable
    {
        Observable _observable;
        private readonly List<IQuackable> _quackers = new List<IQuackable>();

        public void Add(IQuackable quacker)
        {
            _quackers.Add(quacker);
        }

        public void Quack()
        {
            using (var enumerator = _quackers.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    var quacker = enumerator.Current;
                    quacker.Quack();
                }
            }
        }
        public void RegisterObserver(IObserver observer)
        {
            using (var enumerator = _quackers.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    var quacker = enumerator.Current;
                    quacker.RegisterObserver(observer);
                }
            }
            //            _observable.RegisterObserver(observer);
        }

        public void NotifyObservers()
        {
            //            using (var enumerator = _quackers.GetEnumerator())
            //            {
            //                while (enumerator.MoveNext())
            //                {
            //                    var quacker = enumerator.Current;
            //                    quacker.NotifyObservers();
            //                }
            //            }
            //            _observable.NotifyObservers();
            throw new NotImplementedException();
        }
    }
}
