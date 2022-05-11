using System;
using System.Threading;

namespace MyThreading
{
    class Program
    {
        static void Main(string[] args)
        {

            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "Main Thread";
            // Console.WriteLine("main thread name {0}", mainThread.Name);

            Thread thread1 = new Thread(() =>
            {
                CountDown("Timer # 1");
            });
            Thread thread2 = new Thread(() =>
            {
                CountUp("Timer # 2");
            });

            thread1.Start();
            thread2.Start();

            Console.WriteLine("{0} is complete", mainThread.Name);

        }

        public static void CountDown(String name)
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine("Timer # 1 : " + i + " seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("{0} is complete!", name);
        }
        public static void CountUp(String name)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Timer # 2 : " + i + " seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine("{0} is complete!", name);
        }
    }
}