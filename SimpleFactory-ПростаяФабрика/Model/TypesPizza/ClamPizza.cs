using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory_ПростаяФабрика.Model.TypesPizza
{
    class ClamPizza : Pizza
    {
        public override void Prepare() { Console.WriteLine("Prepare clam pizza"); }

        public override void Bake() { Console.WriteLine("Bake clam pizza"); }

        public override void Cute() { Console.WriteLine("Cute clam pizza"); }

        public override void Box() { Console.WriteLine("Box clam pizza"); }
    }
}
