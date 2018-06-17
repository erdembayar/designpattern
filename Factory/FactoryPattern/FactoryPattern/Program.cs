using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SimplePizzaFactory factory = new SimplePizzaFactory();
            PizzaStore store = new PizzaStore(factory);

            Pizza pizza = store.orderPizza("cheese");
            Console.WriteLine("We ordered a " + pizza.getName() + "\n");
            Console.WriteLine(pizza);

            pizza = store.orderPizza("veggie");
            Console.WriteLine("We ordered a " + pizza.getName() + "\n");
            Console.WriteLine(pizza);

            pizza = store.orderPizza("pepperoni");
            Console.WriteLine("We ordered a " + pizza.getName() + "\n");
            Console.WriteLine(pizza);

            Console.ReadKey();
        }
    }
}
