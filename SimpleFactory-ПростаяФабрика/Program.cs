using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleFactory_ПростаяФабрика.Model;

//Создаем свою пицерию
namespace SimpleFactory_ПростаяФабрика
{
    class Program
    {
        static void Main(string[] args)
        {
            SimplePizzaFactory nyFactory = new SimplePizzaFactory();
            PizzaStore nyStore = new PizzaStore(nyFactory);
            nyStore.OrderPizza("cheese");
            nyStore.OrderPizza("pepperoni");
            nyStore.OrderPizza("clam");
            nyStore.OrderPizza("veggie");


            Console.ReadLine();
        }
    }
}
