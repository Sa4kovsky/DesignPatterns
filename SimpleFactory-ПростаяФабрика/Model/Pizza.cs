using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory_ПростаяФабрика.Model
{
    /*Продукт производимый фабрикой. Абстрактный калсс с реализацией который могут переопределять субклассы. */
    public abstract class Pizza
    {
        public virtual void Prepare() { }

        public virtual void Bake() { }

        public virtual void Cute() { }

        public virtual void Box() { }
    }
}
