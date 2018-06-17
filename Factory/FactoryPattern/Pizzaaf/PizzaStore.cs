using System;

namespace Pizzaaf
{
    public abstract class PizzaStore
    {
        protected abstract Pizza createPizza(string item);

        public Pizza orderPizza(string type)
        {
            Pizza pizza = createPizza(type);
            Console.WriteLine("--- Making a " + pizza.getName() + " ---");
            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();
            return pizza;
        }
    }
}
