using System.Collections.Generic;
using System.Text;

namespace Pizzafm
{
    public abstract class Pizza
    {
        public string name { get; protected set; }
        protected string dough;
        protected string sauce;
        protected List<string> toppings = new List<string>();

        public void prepare()
        {
            System.Console.WriteLine("Prepare "+name);
            System.Console.WriteLine("Tossing ...");
            System.Console.WriteLine("Adding sauce ...");
            System.Console.WriteLine("Adding toppings ...");
            foreach (var topping in toppings)
            {
                System.Console.WriteLine("  " +topping);
            }
        }

       public void bake()
        {
            System.Console.WriteLine("Banke for 25 minites at 350");
        } 

        public virtual void cut()
        {
            System.Console.WriteLine("Cut the pizza into diagonal slices");
        }

        public void box()
        {
            System.Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public override string ToString()
        {
            StringBuilder display = new StringBuilder();
            display.Append("---- " + name + " ----\n");
            display.Append(dough + "\n");
            display.Append(sauce + "\n");
            foreach (var topping in toppings)
            {
                display.Append(topping + "\n");
            }

            return display.ToString();
        }

        public string getName()
        {
            return name;
        }
    }
}
