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

            store.OrderCoffee("espresso");
            store.OrderCoffee("doppio");
            store.OrderCoffee("lungo");
            store.OrderCoffee("macchiato");
            store.OrderCoffee("corretta");
            store.OrderCoffee("conpanna");
            store.OrderCoffee("cappucinno");
            store.OrderCoffee("americano");
            store.OrderCoffee("caffelatte");
            store.OrderCoffee("flatwhite");
            store.OrderCoffee("romana");
            store.OrderCoffee("morocchino");
            store.OrderCoffee("mocha");
            store.OrderCoffee("bicerin");
            store.OrderCoffee("breve");
            store.OrderCoffee("rafcoffee");
            store.OrderCoffee("meadraf");
            store.OrderCoffee("galao");
            store.OrderCoffee("caffeaffogato");
            store.OrderCoffee("viennacoffee");
            store.OrderCoffee("glace");
            store.OrderCoffee("chocolatemilk");
            store.OrderCoffee("demicreme");
            store.OrderCoffee("lattemacchiato");
            store.OrderCoffee("freddo");
            store.OrderCoffee("frappuccino");
            store.OrderCoffee("caramelfrappuccino");
            store.OrderCoffee("frappe");
            store.OrderCoffee("irishcoffee");

            Console.ReadLine();
        }
    }
}