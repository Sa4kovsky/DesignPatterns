using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethod_ШаблонныйМетод.TemplateMethod;

namespace TemplateMethod_ШаблонныйМетод.Model
{
    public class TeaWithHook : CaffeineBeverageWithHook
    {
        protected override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding Lemon");
        }

        public override bool CustomerWantsCondiments()
        {
            var answer = GetUserInput();
            if (answer == "yes")
            {
                return true;
            }
            return false;
        }

        private string GetUserInput()
        {
            Console.WriteLine("Would you like sugar with you tea (y/n) ?");
            var keyInfo = Console.ReadKey();
            return keyInfo.KeyChar == 'y' ? "yes" : "no";
        }

    }
}
