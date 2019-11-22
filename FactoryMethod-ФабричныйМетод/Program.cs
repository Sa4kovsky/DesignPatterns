using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod_ФабричныйМетод.Model;
using FactoryMethod_ФабричныйМетод.Model.FactoryPizza;

namespace FactoryMethod_ФабричныйМетод
{
    //PizzaStore расширяется появляюся региональные пицерии. Появилась проблема региональных различий пиц. 
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NYPizzaFactory();
            nyStore.OrderPizza("cheese");
            


            PizzaStore chicagoFactory = new ChicagoPizzaFactory();
            chicagoFactory.OrderPizza("cheese");


            Console.ReadLine();
        }
    }
}
