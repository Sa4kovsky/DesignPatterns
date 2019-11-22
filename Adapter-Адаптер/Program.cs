using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adapter_Адаптер.Adapters;
using Adapter_Адаптер.Model;
using Adapter_Адаптер.Model.Interface;

namespace Adapter_Адаптер
{
    // простой пример адаптера 
    class Program
    {
        static void Main(string[] args)
        {
            DuckTestDrive();
        }

        static void DuckTestDrive()
        {
            IDuck duck = new Duck();
            var turkey = new Turkey();
            IDuck turkeyAdapter = new TurkeyAdapter(turkey);

            Console.WriteLine("Turkey says.........");
            turkey.Gobble();
            turkey.Fly();

            Console.WriteLine("Duck says.........");
            TestDuck(duck);

            Console.WriteLine("TurkeyAdapter says.........");
            TestDuck(turkeyAdapter);

            Console.ReadLine();
        }

        static void TestDuck(IDuck duck)
        {
            duck.Quack();
            duck.Fly();
        }
    }
}
