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
    public class NewYorkPizzaStore : PizzaStore
    {
        protected override Pizza.AbstractPizza.Pizza CreatePizza(string type)
        {
            var factory = new NewYorkPizzaIngredientFactory();
            Pizza.AbstractPizza.Pizza pizza = null;
            switch (type)
            {
                case "cheese":
                    pizza = new CheesePizza(factory);
                    pizza.Name = "New York Cheese Pizza";
                    break;
                case "clams":
                    pizza = new ClamsPizza(factory);
                    pizza.Name = "New York Clams Pizza";
                    break;
            }
            return pizza;
        }
    }
}
