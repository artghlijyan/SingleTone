using System;

namespace SingleTone
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleTone instance1 = SingleTone.GetInstance();
            SingleTone instance2 = SingleTone.GetInstance();

            Console.WriteLine(Object.ReferenceEquals(instance1, instance2));
        }
    }
}
