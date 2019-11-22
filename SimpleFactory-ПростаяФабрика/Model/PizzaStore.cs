using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory_ПростаяФабрика.Model
{
    /*Клиент фабрики обращающийся к SimplePizzaFactory для получения экземпляров.*/
    public class PizzaStore
    {
        //Классу PizzaStore передается ссылка на SimplePizzaFactory
        SimplePizzaFactory factory;

        public PizzaStore(SimplePizzaFactory factory)
        {
            this.factory = factory;
        }

        /// <summary>
        /// Метод для определеня какую пицу хотят
        /// </summary>
        /// <param name="type">Тип пицы для выпечкм</param>
        /// <returns></returns>
        public Pizza OrderPizza(string type)
        {
            Pizza pizza;

            pizza = factory.CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cute();
            pizza.Box();

            return pizza;
        }
    }
}
