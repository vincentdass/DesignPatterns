using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            Console.WriteLine("In RubberDuck cctor.");
            quackBehavior = new MuteQuack();
            flyBehavior = new FlyNoWay();
        }

        public override void Display()
        {
            Console.WriteLine("Rubber duck is displayed");
        }
    }
}
