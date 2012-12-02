using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            setDescription("Espresso");
        }

        public override double cost()
        {
            return 1.99;
        }
    }
}
