using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public abstract class Duck
    {
        protected IQuackBehavior quackBehavior;
        protected IFlyBehavior flyBehavior;

        public Duck()
        {
            Console.WriteLine("In DUCK cctor.");
        }

        public abstract void Display();

        public void PerformQuack()
        {
            quackBehavior.Quack();
        }

        public void PerformFly()
        {
            flyBehavior.Fly();
        }

        public void Swim()
        {
            Console.WriteLine("Swimming! O... Swimming!");
        }

        public void SetFlyBehavior(IFlyBehavior flyBehavior)
        {
            this.flyBehavior = flyBehavior;
        }

        public void SetQuackBehavior(IQuackBehavior quackBehavior)
        {
            this.quackBehavior = quackBehavior;
        }
    }
}
