using Starbuzz_Декоратор.Model;
using Starbuzz_Декоратор.Model.CondimentDecorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuzz_Декоратор
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Espresso();
            Console.WriteLine(beverage.GetDescription() + " $" + beverage.Cost());

            Beverage beverageDark = new DarkRoast();
            beverageDark = new Mocha(beverageDark);
            beverageDark = new Mocha(beverageDark);
            beverageDark = new Whip(beverageDark);
            Console.WriteLine(beverageDark.GetDescription() + " $" + beverageDark.Cost());

            Beverage beverageHouse = new HouseBlend();
            beverageHouse = new Mocha(beverageHouse);
            beverageHouse = new Soy(beverageHouse);
            beverageHouse = new Whip(beverageHouse);
            Console.WriteLine(beverageHouse.GetDescription() + " $" + beverageHouse.Cost());

            Console.ReadLine();
        }
    }
}
