using Duck.Abstract;

namespace Duck.Decorator
{
    //Подсчет уток без изменения Duck
    public class QuackCounter : IQuackable
    {
        IQuackable _iDuck;

        static int _numberOfQucks;

        public QuackCounter(IQuackable duck)
        {
            _iDuck = duck;
        }

        public void Quack()
        {
            _iDuck.Quack();
            _numberOfQucks++;
        }

        public static int GetQuacks()
        {
            return _numberOfQucks;
        }

        public void RegisterObserver(IObserver observer)
        {
            _iDuck.RegisterObserver(observer);
        }

        public void NotifyObservers()
        {
            _iDuck.NotifyObservers();
        }
    }
}
