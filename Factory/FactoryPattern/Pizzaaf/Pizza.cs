using System;
using System.Text;

namespace Pizzaaf
{
    public abstract class Pizza
    {
        protected string name;

        protected Dough dough;
        protected Sauce sauce;
        protected Veggies[] veggies;
        protected Cheese cheese;
        protected Pepperoni pepperoni;
        protected Clams clam;

        public abstract void prepare();

        public void bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public void cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public void box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }

        public String toString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("---- " + name + " ----\n");
            if (dough != null)
            {
                result.Append(dough);
                result.Append("\n");
            }

            if (sauce != null)
            {
                result.Append(sauce);
                result.Append("\n");
            }

            if (cheese != null)
            {
                result.Append(cheese);
                result.Append("\n");
            }

            if (veggies != null)
            {
                for (int i = 0; i < veggies.Length; i++)
                {
                    result.Append(veggies[i]);
                    if (i < veggies.Length - 1)
                    {
                        result.Append(", ");
                    }
                }

                result.Append("\n");
            }

            if (clam != null)
            {
                result.Append(clam);
                result.Append("\n");
            }

            if (pepperoni != null)
            {
                result.Append(pepperoni);
                result.Append("\n");
            }

            return result.ToString();

        }
    }
}