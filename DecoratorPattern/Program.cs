using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage myEspresso = new Espresso();
            myEspresso = new Mocha(myEspresso);
            myEspresso = new Soy(myEspresso);
            myEspresso = new Whip(myEspresso);

            Console.WriteLine(myEspresso.getDescription() + " " + myEspresso.cost());

            Console.ReadLine();
        }
    }
}
