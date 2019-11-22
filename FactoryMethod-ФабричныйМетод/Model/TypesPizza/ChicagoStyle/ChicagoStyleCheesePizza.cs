using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_ФабричныйМетод.Model.TypesPizza
{
    class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            Name = "Chicago Style Deep Dish Cheese Pizza";
            Douth = "Extra Thick Crust Dough";
            Sauce = "Plum Tomato Sauce";

            toppings.Add("Shredded Mozzarella Cheese");
            toppings.Add("Shredded Mozzarella Cheese");
        }

        public void Cute() { Console.WriteLine("Cutting the pizza into square slices"); }
    }
}
