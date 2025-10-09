using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;
using SimpleFactory;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CoffeeStore store = new StarbuzzCoffeeStore();

            store.OrderCoffee("espresso", Size.TALL);
            store.OrderCoffee("doppio", Size.TALL);
            store.OrderCoffee("lungo", Size.TALL);
            store.OrderCoffee("macchiato", Size.TALL);
            store.OrderCoffee("corretta", Size.TALL);
            store.OrderCoffee("conpanna", Size.TALL);
            store.OrderCoffee("cappucinno", Size.TALL);
            store.OrderCoffee("americano", Size.TALL);
            store.OrderCoffee("caffelatte", Size.TALL);
            store.OrderCoffee("flatwhite", Size.TALL);
            store.OrderCoffee("romana", Size.TALL);
            store.OrderCoffee("morocchino", Size.TALL);
            store.OrderCoffee("mocha", Size.TALL);
            store.OrderCoffee("bicerin", Size.TALL);
            store.OrderCoffee("breve", Size.TALL);
            store.OrderCoffee("rafcoffee", Size.TALL);
            store.OrderCoffee("meadraf", Size.TALL);
            store.OrderCoffee("galao", Size.TALL);
            store.OrderCoffee("caffeaffogato", Size.TALL);
            store.OrderCoffee("viennacoffee", Size.TALL);
            store.OrderCoffee("glace", Size.TALL);
            store.OrderCoffee("chocolatemilk", Size.TALL);
            store.OrderCoffee("demicreme", Size.TALL);
            store.OrderCoffee("lattemacchiato", Size.TALL);
            store.OrderCoffee("freddo", Size.TALL);
            store.OrderCoffee("frappuccino", Size.TALL);
            store.OrderCoffee("caramelfrappuccino", Size.TALL);
            store.OrderCoffee("frappe", Size.TALL);
            store.OrderCoffee("irishcoffee", Size.TALL);

            Console.ReadLine();
        }
    }
}