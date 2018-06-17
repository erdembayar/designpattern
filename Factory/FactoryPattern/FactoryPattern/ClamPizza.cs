namespace FactoryPattern
{
    public class ClamPizza : Pizza
    {
        public ClamPizza():  base("Clam Pizza", "Thin crust", "White garlic sauce")
        {
//            name = "Clam Pizza";
//            dough = "Thin crust";
//            sauce = "White garlic sauce";
            toppings.Add("Clams");
            toppings.Add("Grated parmesan cheese");
        }
    }
}
