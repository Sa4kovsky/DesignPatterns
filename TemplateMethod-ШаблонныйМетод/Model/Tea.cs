using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethod_ШаблонныйМетод.TemplateMethod;

namespace TemplateMethod_ШаблонныйМетод.Model
{
    public class Tea : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }

        public override void AddCondimets()
        {
            Console.WriteLine("Adding Lemon");
        }
    }
}
