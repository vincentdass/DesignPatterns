using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    public sealed class SingletonPatternV1
    {
        private static SingletonPatternV1 instance = null;
        private SingletonPatternV1()
        {
            Console.WriteLine("In SingletonPatternV1 CCTOR");
        }

        // Not thread safe
        public static SingletonPatternV1 GetInstance()
        {
            // Two threads may try to go through if condition and create two different instances!
            if (null == instance)
            {
                Console.WriteLine("Instance is null. Creating a new one");
                instance = new SingletonPatternV1();
            }
            else
            {
                Console.WriteLine("Instance is not null. Reusing the available instance");
            }

            return instance;
        }
    }
}
