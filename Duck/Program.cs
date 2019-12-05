using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Duck.Abstract;
using Duck.Adapter;
using Duck.Decorator;
using Duck.Factory;
using Duck.Models;

namespace Duck
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractDuckFactory _duckFactory = new CountingDuckFactory();
            IQuackable _mallardDuck = _duckFactory.CreateMallarDuck();
            IQuackable _readheadDuck = _duckFactory.CreateRedheadDuck();
            IQuackable _duckCall = _duckFactory.CreateDuckCall();
            IQuackable _rubberDuck = _duckFactory.CreateRubberDuck();
            IQuackable _goose = new GooseAdapter(new Goose());

            Console.WriteLine("\nDuck Simulator\n");

            //Стая уток
            DuckFlock _duckFlock = new DuckFlock();
            _duckFlock.Add(_readheadDuck);
            _duckFlock.Add(_rubberDuck);
            _duckFlock.Add(_duckCall);
            _duckFlock.Add(_goose);

            _mallardDuck.Quack();
            _readheadDuck.Quack();
            _duckCall.Quack();
            _rubberDuck.Quack();
            _goose.Quack();

            Console.WriteLine("\nThe ducks quacks " + QuackCounter.GetQuacks() + " times");

            //Вызов стаи
            _duckFlock.Quack();

            Console.ReadLine();
        }
    }
}
