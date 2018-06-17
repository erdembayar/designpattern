
using System;

namespace Pizzaaf
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();

            Pizza pizza = nyStore.orderPizza("cheese");
            Console.WriteLine("Ethan ordered a " + pizza.getName() + "\n");

            pizza = chicagoStore.orderPizza("cheese");
            Console.WriteLine("Joel ordered a " + pizza.getName() + "\n");

            pizza = nyStore.orderPizza("clam");
            Console.WriteLine("Ethan ordered a " + pizza.getName() + "\n");

            pizza = chicagoStore.orderPizza("clam");
            Console.WriteLine("Joel ordered a " + pizza.getName() + "\n");

            pizza = nyStore.orderPizza("pepperoni");
            Console.WriteLine("Ethan ordered a " + pizza.getName() + "\n");

            pizza = chicagoStore.orderPizza("pepperoni");
            Console.WriteLine("Joel ordered a " + pizza.getName() + "\n");

            pizza = nyStore.orderPizza("veggie");
            Console.WriteLine("Ethan ordered a " + pizza.getName() + "\n");

            pizza = chicagoStore.orderPizza("veggie");
            Console.WriteLine("Joel ordered a " + pizza.getName() + "\n");
            Console.ReadKey();
        }
    }
}
