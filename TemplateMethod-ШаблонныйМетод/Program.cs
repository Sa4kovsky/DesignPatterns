using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethod_ШаблонныйМетод.Model;

namespace TemplateMethod_ШаблонныйМетод
{
    class Program
    {
        static void Main(string[] args)
        {
            MakeTea();
            Console.WriteLine("----------------");
            MakeCoffeeWithHook();
            Console.ReadLine();
        }

        static void MakeTea()
        {
            var tea = new Tea();
            tea.PrepareRecipe();

            Console.WriteLine("***************");

            var coffe = new Coffee();
            coffe.PrepareRecipe();
        }

        static void MakeCoffeeWithHook()
        {
            var teaWithHook = new TeaWithHook();
            Console.WriteLine("Making tea...");
            teaWithHook.PrepareRecipe();

            Console.WriteLine("***************");

            var coffeeWithHook = new CoffeeWithHook();
            Console.WriteLine("Making coffee...");
            coffeeWithHook.PrepareRecipe();
        }
    }
}
