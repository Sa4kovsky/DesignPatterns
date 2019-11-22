using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethod_ШаблонныйМетод.TemplateMethod;

namespace TemplateMethod_ШаблонныйМетод.Model
{
    public class Coffee : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Dripping Coffe through filter water");
        }

        public override void AddCondimets()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }
    }
}
