using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace DecoratorPattern
{
    public abstract class AddonDecorator : Beverage
    {
        internal Beverage beverage;
        public override abstract double Cost();

        public AddonDecorator(Beverage beverage)
        {
            this.beverage = beverage;
        }
    }

    public class Caramel : AddonDecorator
    {
        
        public Caramel(Beverage beverage) : base(beverage)
        {
            Console.WriteLine("Added Caramel Addon");
        }

        public override double Cost()
        {
            Console.WriteLine("##DEBUG - In Caramel Cost()");
            return this.beverage.Cost() + 1.0;
        }
    }

    public class Chocolate : AddonDecorator
    {
        public Chocolate(Beverage beverage) : base(beverage)
        {
            Console.WriteLine("Added Chocolate Addon");
        }

        public override double Cost()
        {
            Console.WriteLine("##DEBUG - In Chocolate Cost()");
            return this.beverage.Cost() + 2.0;
        }
    }
}
