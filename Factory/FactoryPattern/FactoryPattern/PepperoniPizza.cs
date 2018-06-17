namespace FactoryPattern
{
    public class PepperoniPizza : Pizza
    {

    public PepperoniPizza() : base("Pepperoni Pizza", "Crust", "BBQ sauce")
    {
//        name = "Pepperoni Pizza";
//        dough = "Crust";
//        sauce = "Marinara sauce";
        toppings.Add("Sliced Pepperoni");
        toppings.Add("Sliced Onion");
        toppings.Add("Grated parmesan cheese");
    }
}

}
