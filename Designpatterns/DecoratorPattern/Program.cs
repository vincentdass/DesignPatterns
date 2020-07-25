using System;
using System.Security.Cryptography.X509Certificates;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage b;
            Console.Write("Select 1 for Espress / 2 for Decaf. Your Choice: ");
            int t = Int32.Parse(Console.ReadLine());
            if(t == 1)
            {
                b = new Espresso();
            }
            else
            {
                b = new DeCaf();
            }
            while(true)
            {
                Console.Write("Select 1 for Caramel / 2 for Chocolate / 3 for exit. Your choice: ");
                int a = Int32.Parse(Console.ReadLine()); 
                if(a == 3)
                {
                    break;
                }
                else if(a == 1)
                {
                    b = new Caramel(b);
                }
                else if(a == 2)
                {
                    b = new Chocolate(b);
                }
                else
                {
                    Console.WriteLine("Invalid option! select again");
                }
            }

            Console.WriteLine($"Total Cost: {b.Cost()}");
            Console.ReadLine();
        }
    }
}
