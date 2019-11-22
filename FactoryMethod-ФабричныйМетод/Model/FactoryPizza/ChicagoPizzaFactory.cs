using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod_ФабричныйМетод.Model.TypesPizza;

namespace FactoryMethod_ФабричныйМетод.Model.FactoryPizza
{
    //фабрика для приготовления пицы в чикагском стиле
    class ChicagoPizzaFactory : PizzaStore
    {           
        protected override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "cheese":
                    return new ChicagoStyleCheesePizza();
                    
  /*              case "pepperoni":
                    return new ChicagoStylePepperoniPizza();
                    
                case "clam":
                    return new ChicagoStyleClamPizza();
                    
                case "veggie":
                    return new ChicagoStyleVegglePizza(); */      
            }
            return null;   
        }
    }
}
