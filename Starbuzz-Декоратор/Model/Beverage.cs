using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuzz_Декоратор.Model
{
    public abstract class Beverage
    {
        string description = "Unknown Beverage";

        public virtual string GetDescription() => description;

        public abstract double Cost();
    }
}
