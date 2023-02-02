namespace factory_pattern
{
    public class NYPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string item)
        {
            if (item == "cheese")
            {
                return new NYStyleCheesePizza();
            }

            return null;
        }
    }
}
