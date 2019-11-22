using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleFactory_ПростаяФабрика.Model.TypesPizza;

namespace SimpleFactory_ПростаяФабрика.Model
{
    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            switch (type)
            {
                case "cheese":
                    pizza = new CheesePizza();
                    break;
                case "pepperoni":
                    pizza = new PepperoniPizza();
                    break;
                case "clam":
                    pizza = new ClamPizza();
                    break;
                case "veggie":
                    pizza = new VegglePizza();
                    break;
            }
            
            return pizza;
        }
    }
}
