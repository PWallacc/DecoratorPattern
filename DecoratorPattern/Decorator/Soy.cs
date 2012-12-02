using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    public class Soy : CondimentDecorator
    {
        Beverage mBeverage;

        public Soy(Beverage pBeverage)
        {
            this.mBeverage = pBeverage;
        }

        public override String getDescription()
        {
            return mBeverage.getDescription() + ", Soy";
        }

        public override double cost()
        {
            return .15 + mBeverage.cost();
        }
    }
}
