using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuzz_Декоратор.Model
{
    public class DarkRoast : Beverage
    {
        public override string GetDescription() => "Dark Roast";
        
        public override double Cost()
        {
            return .99;
        }
    }
}
