using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public interface IFlyBehavior
    {
        public void Fly();
    }

    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Fly with Wings behavior");
        }
    }

    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Cannot fly! Are you serious?!");
        }
    }
}
