using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory_ПростаяФабрика.Model.TypesPizza
{
    class CheesePizza : Pizza
    {
        public override void Prepare() { Console.WriteLine("Prepare cheese pizza"); }

        public override void Bake() { Console.WriteLine("Bake cheese pizza"); }

        public override void Cute() { Console.WriteLine("Cute cheese pizza"); }

        public override void Box() { Console.WriteLine("Box cheese pizza"); }
    }
}
