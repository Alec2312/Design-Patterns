using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages
{
    internal class Water : Beverage
    {
        public Water(Beverage beverage = null)
        {
            description = "Water";
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
                case Size.TALL: extra = 0.05; break;
                case Size.GRANDE: extra = 0.10; break;
                case Size.VENDI: extra = 0.30; break;
            }

            if (baseBeverage != null)
            {
                return 0.50 + extra + baseBeverage.cost();
            }

            return 0.50 + extra;
        }
    }
}
