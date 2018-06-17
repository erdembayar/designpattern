using System;

namespace Pizzaaf
{
    public class VeggiePizza : Pizza
    {
        private PizzaIngredientFactory ingredientFactory;

        public VeggiePizza(PizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }
        public override void prepare()
        {
            Console.WriteLine("Preparing " + name);
            dough = ingredientFactory.CreateDough();
            sauce = ingredientFactory.CreateSauce();
            cheese = ingredientFactory.CreateCheese();
            veggies = ingredientFactory.CreateVeggies();
        }
    }
}
