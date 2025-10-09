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
        public Beverage OrderCoffee(string type, Size size)
        {
            Beverage beverage = CreateCoffee(type, size);
            PrintBeverage(beverage);
            return beverage;
        }
        public abstract Beverage CreateCoffee(string type, Size size);

        static void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine(beverage.GetDescription() + " $" + beverage.cost().ToString("#.##"));
        }
    }

}
