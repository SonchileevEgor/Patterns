using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton1 = null;
            Singleton singleton2 = null;

            Thread process1 = new Thread(() => {
                TestSingleton("First");
            });
            Thread process2 = new Thread(() => {
                TestSingleton("Second");
            });

            process1.Start();
            process2.Start();

            process1.Join();
            process2.Join();

            if (singleton1 == singleton2)
            {
                Console.WriteLine("Singleton works");
            }
        }

        public static void TestSingleton(string value)
        {
            Singleton singleton = Singleton.GetInstance(value);
            Console.WriteLine(singleton.Value);
        }
    }
}