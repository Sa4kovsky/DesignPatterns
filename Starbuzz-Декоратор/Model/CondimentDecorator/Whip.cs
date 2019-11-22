using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuzz_Декоратор.Model.CondimentDecorator
{
    public class Whip : CondimentDecorator
    {
        Beverage beverage;

        public Whip(Beverage beverage)
        {
            this.beverage = beverage; 
        }

        public override string GetDescription() => beverage.GetDescription() + ", Whip";

        public override double Cost()
        {
            return .10 + beverage.Cost();
        }
    }
}
