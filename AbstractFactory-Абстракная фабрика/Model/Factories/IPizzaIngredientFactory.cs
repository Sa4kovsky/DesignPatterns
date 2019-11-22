using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory_Абстракная_фабрика.Model.AbstractionsСomposition;

namespace AbstractFactory_Абстракная_фабрика.Model.Factories
{
    public interface IPizzaIngredientFactory
    {
        IDough CreateDough();
        ICheese CreateCheese();
        IClams CreateClams();
        ISauce CreateSauce();
    }
}
