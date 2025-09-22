using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Condiments
{
    internal class Lemon : CondimentDecorator
    {
        public Lemon(Beverage beverage)
        {
            this.baseBeverage = beverage;
        }

        public override double cost()
        {
            double extra = 0;

            switch (baseBeverage.Size)
            {
                case Size.TALL: extra = 0.10; break;
                case Size.GRANDE: extra = 0.15; break;
                case Size.VENDI: extra = 0.20; break;
            }

            return 0.30 + extra + baseBeverage.cost();
        }

        public override string GetDescription()
        {
            return baseBeverage.GetDescription() + ", Lemon";
        }
    }
}
