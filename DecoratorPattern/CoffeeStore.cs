using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Beverages;

namespace SimpleFactory
{
    internal abstract class CoffeeStore
    {
        public Beverage OrderCoffee(string type)
        {
            Beverage beverage = CreateCoffee(type);

            PrintBeverage(beverage);
            return beverage;
        }
        public abstract Beverage CreateCoffee(string type);

        static void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine(beverage.GetDescription() + " $" + beverage.cost().ToString("#.##"));
        }
    }

}
