using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public interface IQuackBehavior
    {
        public void Quack();
    }

    public class QuackQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack! Quack!");
        }
    }

    public class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Cannot Quack da!");
        }
    }
}
