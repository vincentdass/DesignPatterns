using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    public sealed class SingletonPatternV2
    {
        private static SingletonPatternV2 instance = null;
        private static readonly object _lockObject = new object();


        private SingletonPatternV2()
        {
            Console.WriteLine("In SingletonPatternV2 CCTOR");
        }

        public static SingletonPatternV2 GetInstance()
        {
            if(instance == null)
            {
                lock(_lockObject)
                {
                    if(instance == null)
                    {
                        Console.WriteLine("Instance is null. Creating a new one");
                        instance = new SingletonPatternV2();
                    }
                }
            }
            else
            {
                Console.WriteLine("Instance is not null. Reusing the available instance");
            }

            return instance;
        }
    }
}
