using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_ФабричныйМетод.Model.TypesPizza
{
    class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza()
        {
            Name = "NY Style Saice and Cheese Pizza";
            Douth = "Thin Crust Dought";
            Sauce = "Marinara Sauce";

            toppings.Add("Grated Reggiano Cheese");
        }
    }
}
