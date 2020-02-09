using System;
using System.Threading;

namespace SingleTone
{
    class Program
    {
        static void Main2()
        {
            string s = "From Thread";
            SingleTone instance = SingleTone.GetInstance();
            instance.Test(s);
        }
        static void Main(string[] args)
        {
            Thread thread = new Thread(Main2);
            thread.Start();
            SingleTone instance1 = SingleTone.GetInstance();
            Console.WriteLine(instance1);
        }
    }
}
