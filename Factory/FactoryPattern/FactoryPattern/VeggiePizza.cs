﻿namespace FactoryPattern
{
    public class VeggiePizza : Pizza
    {

    public VeggiePizza() : base("Veggie Pizza", "Crust", "Marinara Sauce")
    {
//        name = "Veggie Pizza";
//        dough = "Crust";
//        sauce = "Marinara sauce";
        toppings.Add("Shredded mozzarella");
        toppings.Add("Grated parmesan");
        toppings.Add("Diced onion");
        toppings.Add("Sliced mushrooms");
        toppings.Add("Sliced red pepper");
        toppings.Add("Sliced black olives");
    }
}

}
