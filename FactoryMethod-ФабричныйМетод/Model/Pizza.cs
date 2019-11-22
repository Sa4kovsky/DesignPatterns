using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_ФабричныйМетод.Model
{
    /*Продукт производимый фабрикой. Абстрактный калсс с реализацией который могут переопределять субклассы. */
    public abstract class Pizza
    {
        public string Name { get; set; }
        public string Douth { get; set; }
        public string Sauce { get; set; }
        public List<string> toppings = new List<string>();

        public void Prepare()
        {
            Console.WriteLine("Prepare " + Name);
            Console.WriteLine("Tossing douth ... " + Douth);
            Console.WriteLine("Adding sauce ... " + Sauce);
            Console.WriteLine("Adding toppings: ");
            foreach (string topping in toppings)
            {
                Console.WriteLine(topping);
            }
        }

        public void Bake() { Console.WriteLine("Bake for 25 minutes at 350");  }

        public void Cute() { Console.WriteLine("Cutting the pizza into diagonal slices"); }

        public void Box() { Console.WriteLine("Place pizza in official PizzaStore box");  }
    }
}
