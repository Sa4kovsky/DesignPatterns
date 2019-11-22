using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuzz_Декоратор.Model
{
    public class HouseBlend : Beverage
    {
        public override string GetDescription() => "House Blend Coffee";

        public override double Cost()
        {
            return .89;
        }
    }
}
