using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            setDescription("Decaf");
        }

        public override double cost()
        {
            return 1.05;
        }
    }
}
