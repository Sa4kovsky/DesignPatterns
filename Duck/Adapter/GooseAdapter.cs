using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Duck.Abstract;
using Duck.Models;
using Duck.Observal;

namespace Duck.Adapter
{
    //Чтобы гусь вел себя как утка
    public class GooseAdapter : IQuackable
    {
        Goose _goose;
        Observable _observable;

        public GooseAdapter(Goose goose)
        {
            _goose = goose;
        }

        public void Quack()
        {
            _goose.Honk();
        }

        public void RegisterObserver(IObserver goose)
        {
            _observable.RegisterObserver(goose);
        }

        public void NotifyObservers()
        {
            _observable.NotifyObservers();
        }
    }
}
