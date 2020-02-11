using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    public sealed class SingletonPatternV3
    {
        private static readonly SingletonPatternV3 instance = new SingletonPatternV3();

        private SingletonPatternV3()
        {
            Console.WriteLine("In SingletonPatternV3 Private CCTOR");
        }

        static SingletonPatternV3()
        {
            Console.WriteLine("In SingletonPatternV3 Static CCTOR");
        }

        public static SingletonPatternV3 GetInstance()
        {
            Console.WriteLine("Getting instance of SingletonPatternV3");
            return instance;
        }
    }
}
