namespace factory_pattern
{
    public class ChicagoPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string item)
        {
            if (item == "cheese")
            {
                return new ChicagoStyleCheesePizza();
            }

            return null;
        }
    }
}
