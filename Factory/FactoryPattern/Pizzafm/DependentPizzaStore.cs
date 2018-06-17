using System;

namespace Pizzafm
{
    class DependentPizzaStore 
    {
        protected Pizza createPizza(string style, string type)
        {
            Pizza pizza = null;
            if (style.Equals("NY"))
            {
                if (type.Equals("cheese"))
                {
                    pizza = new NYStyleCheesePizza();
                }
                else if (type.Equals("veggie"))
                {
                    pizza = new NYStyleVeggiePizza();
                }
                else if (type.Equals("clam"))
                {
                    pizza = new NYStyleClamPizza();
                }
                else if (type.Equals("pepperoni"))
                {
                    pizza = new NYStylePepperoniPizza();
                }
            }
            else if (style.Equals("Chicago"))
            {
                if (type.Equals("cheese"))
                {
                    pizza = new ChicagoStyleCheesePizza();
                }
                else if (type.Equals("veggie"))
                {
                    pizza = new ChicagoStyleVeggiePizza();
                }
                else if (type.Equals("clam"))
                {
                    pizza = new ChicagoStyleClamPizza();
                }
                else if (type.Equals("pepperoni"))
                {
                    pizza = new ChicagoStylePepperoniPizza();
                }
            }
            else
            {
                Console.WriteLine("Error: invalid type of pizza");
                return null;
            }
            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();
            return pizza;
        }
    }
}
