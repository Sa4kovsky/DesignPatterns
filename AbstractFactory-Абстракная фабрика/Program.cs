using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory_Абстракная_фабрика.Model.Clients;

namespace AbstractFactory_АбстракнаяФабрика
{
    class Program
    {
        static void Main(string[] args)
        {
            var newYorkPizzaStore = new NewYorkPizzaStore();
            newYorkPizzaStore.OrderPizza("cheese");

            Console.WriteLine("-----------------------------------------------------------");

            var chicagoYorkPizzaStore = new ChicagoPizzaStore();
            chicagoYorkPizzaStore.OrderPizza("cheese");

            Console.ReadKey();
        }
    }
}
