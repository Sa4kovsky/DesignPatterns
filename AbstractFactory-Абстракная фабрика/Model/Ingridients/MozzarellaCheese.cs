using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory_Абстракная_фабрика.Model.AbstractionsСomposition;

namespace AbstractFactory_Абстракная_фабрика.Model.Ingridients
{
    public class MozzarellaCheese : ICheese
    {
        public string Name { get; } = "Mozzarella Cheese";
    }
}
