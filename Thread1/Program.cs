using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;
namespace Thread1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Thread id in main {Thread.CurrentThread.ManagedThreadId}");

            Thread t1, t2;

            ThreadStart ts;
            ParameterizedThreadStart pts;

            ts = new ThreadStart(Task1);

            pts = new ParameterizedThreadStart(Task2);

            t1 = new Thread(ts);
            t1.Name = "Worker1";
            t1.Priority = ThreadPriority.Normal;
           
            t2 = new Thread(pts);
            t2.Name = "Worker2";
            t2.Priority = ThreadPriority.Normal;

            t1.Start();
            t2.Start("Hello threading");

            t1.Join();
            t2.Join();

            Console.WriteLine("Main finished");

            Console.ReadLine();
        }
        static void Task1()
        {
            Console.WriteLine($"Thread id in task1 {Thread.CurrentThread.ManagedThreadId}");
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine( $"Thread id {Thread.CurrentThread.ManagedThreadId} , value in loop {i}");
            }
        }

        static void Task2(object obj)
        {
            Console.WriteLine(obj.ToString());
            Console.WriteLine($"Thread id in task2 {Thread.CurrentThread.ManagedThreadId}");
            for (int i = 100; i > 0; i--)
            {
                Console.WriteLine($"Thread id {Thread.CurrentThread.ManagedThreadId} , value in loop {i}");
            }
        }
    }
}
