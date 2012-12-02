using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    public class Whip : CondimentDecorator
    {
        Beverage mBeverage;

        public Whip(Beverage pBeverage)
        {
            this.mBeverage = pBeverage;
        }

        public override String getDescription()
        {
            return mBeverage.getDescription() + ", Whip";
        }

        public override double cost()
        {
            return .10 + mBeverage.cost();
        }
    }
}
