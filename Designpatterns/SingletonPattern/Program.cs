using System;

namespace SingletonPattern
{
    class Program
    {
        private static void RunSingletonPatternV1()
        {
            SingletonPatternV1.GetInstance();
            SingletonPatternV1.GetInstance();
            SingletonPatternV1.GetInstance();
        }

        private static void RunSingletonPatternV2()
        {
            SingletonPatternV2.GetInstance();
            SingletonPatternV2.GetInstance();
            SingletonPatternV2.GetInstance();
        }

        private static void RunSingletonPatternV3()
        {

            SingletonPatternV3.GetInstance();
            SingletonPatternV3.GetInstance();
            SingletonPatternV3.GetInstance();
        }

        private static void RunSingletonPatternV4()
        {
            SingletonPatternV4.GetInstance();
            SingletonPatternV4.GetInstance();
            SingletonPatternV4.GetInstance();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Start of Main");
            Console.WriteLine("---- SingletonV1");
            RunSingletonPatternV1();
            Console.WriteLine("---- SingletonV2");
            RunSingletonPatternV2();
            Console.WriteLine("---- SingletonV3");
            RunSingletonPatternV3();
            Console.WriteLine("---- SingletonV4");
            RunSingletonPatternV4();
            Console.WriteLine("End of Main");
            Console.ReadLine();
        }
    }
}
