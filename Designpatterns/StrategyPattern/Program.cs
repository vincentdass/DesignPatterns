using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallardDuck = new MallardDuck();
            mallardDuck.Display();
            mallardDuck.PerformFly();
            mallardDuck.PerformQuack();

            Console.WriteLine("*******************");
            Duck rubberDuck = new RubberDuck();
            rubberDuck.Display();
            rubberDuck.PerformFly();
            rubberDuck.PerformQuack();

            Console.WriteLine("*******************");
            Duck modelDuck = new MallardDuck();
            modelDuck.Display();
            modelDuck.PerformFly();
            Console.WriteLine("--- Converting behabiour using set method ---");
            modelDuck.SetFlyBehavior(new FlyNoWay());
            modelDuck.PerformFly();
        }
    }
}
