using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory_ПростаяФабрика.Model.TypesPizza
{
    class VegglePizza : Pizza
    {
        public override void Prepare() { Console.WriteLine("Prepare veggle pizza"); }

        public override void Bake() { Console.WriteLine("Bake veggle pizza"); }

        public override void Cute() { Console.WriteLine("Cute veggle pizza"); }

        public override void Box() { Console.WriteLine("Box veggle pizza"); }
    }
}
