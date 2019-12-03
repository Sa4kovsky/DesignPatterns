using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Duck.Abstract;
using Duck.Adapter;
using Duck.Models;

namespace Duck
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuackable _mallardDuck = new MallardDuck();
            IQuackable _readheadDuck = new RedheadDuck();
            IQuackable _duckCall = new DuckCall();
            IQuackable _rubberDuck = new RubberDuck();
            IQuackable _goose = new GooseAdapter(new Goose());

            Console.WriteLine("\nDuck Simulator\n");

            _mallardDuck.Quack();
            _readheadDuck.Quack();
            _duckCall.Quack();
            _rubberDuck.Quack();
            _goose.Quack();

            Console.ReadLine();
        }
    }
}
