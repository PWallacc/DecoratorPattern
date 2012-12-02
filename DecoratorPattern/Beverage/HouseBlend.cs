using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            setDescription("House Blend");
        }

        public override double cost()
        {
            return .89;
        }
    }
}
