namespace FactoryPattern
{
    public class CheezePizza :Pizza
    {
        public CheezePizza()
        {
            name = "Cheese Pizza";
            dough = "Regular Crust";
            sauce = "Marinara Pizza Sauce";
            toppings.Add("Fresh Mozzarella");
            toppings.Add("Parmesan");
        }
    }
}
