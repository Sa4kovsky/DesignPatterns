using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adapter_Адаптер.Model;
using Adapter_Адаптер.Model.Interface;

namespace Adapter_Адаптер.Adapters
{
    public class TurkeyAdapter : IDuck
    {
        Turkey turkey;

        public TurkeyAdapter(Turkey turkey)
        {
            this.turkey = turkey;
        }

        public void Fly()
        {
            for (int i = 0; i < 5; i++) // так как индюшка летает на короткие расстояния мы вызавем на 5, чтобы установить соответсвие между методами fly()
            {
                turkey.Fly();
            }
        }

        public void Quack()
        {
            turkey.Gobble();
        }
    }
}
