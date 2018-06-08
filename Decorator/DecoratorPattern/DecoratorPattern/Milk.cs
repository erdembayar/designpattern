using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Milk : Beverage
    {
        Beverage beverage;


        public Milk(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string getDescription()
        {
            return beverage.getDescription() + ", Milk";
        }

        public override double cost()
        {
            return .10 + beverage.cost();
        }
    }

}
