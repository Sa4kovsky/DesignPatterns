using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory_Абстракная_фабрика.Model.Factories;
using AbstractFactory_Абстракная_фабрика.Model.Pizza.AbstractPizza;
using AbstractFactory_Абстракная_фабрика.Model.Pizza.ConcretePizza;

namespace AbstractFactory_Абстракная_фабрика.Model.Clients
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza.AbstractPizza.Pizza CreatePizza(string type)
        {
            var factory = new ChicagoPizzaIngredientFactory();
            Pizza.AbstractPizza.Pizza pizza = null;
            switch (type)
            {
                case "cheese":
                    pizza = new CheesePizza(factory);
                    pizza.Name = "Chicago Cheese Pizza";
                    break;
                case "clams":
                    pizza = new ClamsPizza(factory);
                    pizza.Name = "Chicago Clams Pizza";
                    break;
            }
            return pizza;
        }
    }
}
