﻿namespace Pizzaaf
{
    public interface PizzaIngredientFactory
    {
        Dough CreateDough();
        Sauce CreateSauce();
        Cheese CreateCheese();
        Veggies[] CreateVeggies();
        Pepperoni CreatePepperoni();
        Clams CreateClam();
    }
}
