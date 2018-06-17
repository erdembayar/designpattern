namespace FactoryPattern
{
    public class CheezePizza :Pizza
    {
        public CheezePizza() : base("Cheese Pizza", "Regular Crust", "Marinara Pizza sauce")
        {
//            name = "Cheese Pizza";
//            dough = "Regular Crust";
//            sauce = "Marinara Pizza Sauce";
            toppings.Add("Fresh Mozzarella");
            toppings.Add("Parmesan");
        }
    }
}
