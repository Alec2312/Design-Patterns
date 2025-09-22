using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages
{
    internal class Chocolate : Beverage
    {
        public Chocolate(Beverage beverage = null)
        {
            description = "Chocolate";
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
                case Size.TALL: extra = 0.50; break;
                case Size.GRANDE: extra = 0.70; break;
                case Size.VENDI: extra = 0.90; break;
            }

            if (baseBeverage != null)
            {
                return 1.00 + extra + baseBeverage.cost();
            }

            return 1.00 + extra;
        }
    }
}
