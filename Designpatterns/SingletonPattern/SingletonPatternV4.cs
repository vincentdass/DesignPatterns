using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    public sealed class SingletonPatternV4
    {
        private static readonly Lazy<SingletonPatternV4> instance =
            new Lazy<SingletonPatternV4>(() => new SingletonPatternV4());

        private SingletonPatternV4()
        {
            Console.WriteLine("In SingletonPatternV4 Private CCTOR");
        }

        public static SingletonPatternV4 GetInstance()
        {
            Console.WriteLine("Trying to get the instance of SingletonPatternV4");
            return instance.Value;
        }
    }
}
