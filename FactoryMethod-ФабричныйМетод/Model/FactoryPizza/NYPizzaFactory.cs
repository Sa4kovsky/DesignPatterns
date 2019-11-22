using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod_ФабричныйМетод.Model.TypesPizza;

namespace FactoryMethod_ФабричныйМетод.Model.FactoryPizza
{
    //фабрика для приготовления пицы в ньюерском стиле
    class NYPizzaFactory : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "cheese":
                    return new NYStyleCheesePizza();

               /* case "pepperoni":
                    return new NYStylePepperoniPizza();

                case "clam":
                    return new NYStyleClamPizza();

                case "veggie":
                    return new NYStyleVegglePizza();*/
            }
            return null;
        }
    }
}
