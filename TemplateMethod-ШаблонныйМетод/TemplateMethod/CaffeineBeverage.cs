using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod_ШаблонныйМетод.TemplateMethod
{
    public abstract class CaffeineBeverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondimets();
        }

        public void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        public abstract void Brew();
        public abstract void AddCondimets();

        public void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }



    }
}
