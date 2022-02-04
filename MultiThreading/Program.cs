using System;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            firstWay();
            secondWay();
            thirdWay();
            Console.ReadKey();
        }

        static void firstWay()
        {
            var threadStart = new ThreadStart(
                 () => Console.WriteLine($"This is firstWay from thread: {Thread.CurrentThread.ManagedThreadId}")
                ); 
            var thread = new Thread(threadStart);
            thread.Start();
        }

        static void secondWay()
        {
            var callback = new WaitCallback( target => Console.WriteLine($"This is secondWay from thread: {Thread.CurrentThread.ManagedThreadId}"));
            ThreadPool.QueueUserWorkItem(callback);
        }

        static void thirdWay()
        {
            Task task = Task.Run(() => Console.WriteLine($"This is thirdWay part 1 from thread: {Thread.CurrentThread.ManagedThreadId}"));
            task.Wait();
        }

        static void SomeMethod1()
        {
            
        }
    }
}