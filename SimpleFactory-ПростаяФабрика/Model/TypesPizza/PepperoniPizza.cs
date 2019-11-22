using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory_ПростаяФабрика.Model.TypesPizza
{
    class PepperoniPizza : Pizza
    {
        public override void Prepare() { Console.WriteLine("Prepare pepperoni pizza"); }

        public override void Bake() { Console.WriteLine("Bake pepperoni pizza"); }

        public override void Cute() { Console.WriteLine("Cute pepperoni pizza"); }

        public override void Box() { Console.WriteLine("Box pepperoni pizza"); }
    }
}
