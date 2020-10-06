using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public abstract class Beverage
    {
        public abstract double Cost();
    }

    public class Espresso : Beverage
    {
        public Espresso()
        {
            Console.WriteLine("##Debug - In Espresso CCTOR");
        }

        public override double Cost()
        {
            return 1.0;
        }
    }

    public class DeCaf : Beverage
    {
        public DeCaf()
        {
            Console.WriteLine("##Debug - In DeCaf CCTOR");
        }

        public override double Cost()
        {
            return 2.0;
        }
    }
}
