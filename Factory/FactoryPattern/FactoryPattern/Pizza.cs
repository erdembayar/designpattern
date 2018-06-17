using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{

    abstract public class Pizza
    {
        private string name { get; set; }
        private string dough { get; set; }
        private string sauce { get; set; }
        protected List<String> toppings = new List<String>();

        public Pizza(string _name, string _dough, string _sauce)
        {
            name = _name;
            dough = _dough;
            sauce = _sauce;
        }
        public String getName()
        {
            return name;
        }

        public void prepare()
        {
            Console.WriteLine("Preparing " + name);
        }

        public void bake()
        {
            Console.WriteLine("Baking " + name);
        }

        public virtual void cut()
        {
            Console.WriteLine("Cutting " + name);
        }

        public void box()
        {
            Console.WriteLine("Boxing " + name);
        }

        public override String ToString()
        {
            // code to display pizza name and ingredients
            StringBuilder display = new StringBuilder();
            display.Append("---- " + name + " ----\n");
            display.Append(dough + "\n");
            display.Append(sauce + "\n");
            foreach (String topping in toppings)
            {
                display.Append(topping + "\n");
            }
            return display.ToString();
        }
    }
}
