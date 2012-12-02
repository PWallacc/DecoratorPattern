using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            setDescription("Dark Roast");
        }

        public override double cost()
        {
            return .99;
        }
    }
}
