using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            Console.WriteLine("In MallardDuck cctor.");
            quackBehavior = new QuackQuack();
            flyBehavior = new FlyWithWings();
        }
        public override void Display()
        {
            Console.WriteLine("Mallard Duck is displayed!");
        }
    }
}
