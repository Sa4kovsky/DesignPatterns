using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_ФабричныйМетод.Model
{
    public abstract class PizzaStore
    {
        /// <summary>
        /// Метод для определеня какую пицу хотят
        /// </summary>
        /// <param name="type">Тип пицы для выпечкм</param>
        /// <returns></returns>
        public Pizza OrderPizza(string type)
        {
            Pizza pizza;

            pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cute();
            pizza.Box();

            return pizza;
        }

        protected abstract Pizza CreatePizza(string type);
    }
}
