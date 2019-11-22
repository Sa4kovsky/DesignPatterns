using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuzz_Декоратор.Model.CondimentDecorator
{
    public class Soy : CondimentDecorator
    {
        Beverage beverage;

        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription() => beverage.GetDescription() + ", Soy";

        public override double Cost()
        {
            return .15 + beverage.Cost();
        }
    }
}
