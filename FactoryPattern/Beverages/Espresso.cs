using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages
{
    internal class Espresso : Beverage
    {
        public Espresso(Beverage beverage = null)
        {
            description = "Espresso";
            this.baseBeverage = beverage;
        }

        public override string GetDescription()
        {
            if (baseBeverage != null)
            {
                return baseBeverage.GetDescription() + ", " + description;
            }
            return description;
        }

        public override double cost()
        {
            double extra = 0.0;
            switch (Size)
            {
                case Size.TALL: extra = 0.30; break;
                case Size.GRANDE: extra = 0.50; break;
                case Size.VENDI: extra = 0.80; break;
            }
            
            if (baseBeverage != null)
            {
                return 1.99 + extra + baseBeverage.cost();
            }

            return 1.99 + extra;
        }
    }
}
