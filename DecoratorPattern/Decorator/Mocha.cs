using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    public class Mocha : CondimentDecorator
    {
        Beverage mBeverage;

        public Mocha(Beverage pBeverage)
        {
            this.mBeverage = pBeverage;
        }

        public override String getDescription()
        {
            return mBeverage.getDescription() + ", Mocha";
        }

        public override double cost()
        {
            return .20 + mBeverage.cost();
        }
    }
}
