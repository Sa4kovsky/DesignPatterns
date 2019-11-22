using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuzz_Декоратор.Model
{
    public class Espresso : Beverage
    {
        public override string GetDescription() => "Espresso";

        public override double Cost()
        {
            return 1.99;
        }
    }
}
