using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    public abstract class Beverage
    {
        private String description = "Unknown Beverage";

        public virtual String getDescription()
        {
            return description;
        }

        public void setDescription(String pDesc)
        {
            description = pDesc;
        }
        public abstract double cost();
    }
}
