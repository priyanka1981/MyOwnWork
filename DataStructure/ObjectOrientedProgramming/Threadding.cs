using System;
using System.Threading;

namespace DataStructure.ObjectOrientedProgramming
{
    public class Threadding
    {
        public Threadding()
        {
        }

        static void Main(string[] args)
        {
            object lock1 = new object();
            object lock2 = new object();
            new Thread(() => LockTooMuch(lock1, lock2)).Start(); 
            lock (lock2) { Thread.Sleep(1000); 
                Console.WriteLine("Monitor.TryEnter allows not to get stuck, returning false after a specified timeout is elapsed"); 
                if (Monitor.TryEnter(lock1, TimeSpan.FromSeconds(5))) { 
                Console.WriteLine("Acquired a protected resource succesfully"); } 
                else { 
                    Console.WriteLine("Timeout acquiring a resource!"); } }
            new Thread(() => LockTooMuch(lock1, lock2)).Start(); 
            Console.WriteLine("----------------------------------"); lock (lock2) { 
                Console.WriteLine("This will be a deadlock!"); 
                Thread.Sleep(1000); lock (lock1) { 
                    Console.WriteLine("Acquired a protected resource succesfully"); } }
        }

        static void LockTooMuch(object l1,object l2){
            lock(l1){
                Thread.Sleep(2000);
                lock (l2);
            }
        }

        static SemaphoreSlim _semaphore = new SemaphoreSlim(4); 
        static void AccessDatabase(string name, int seconds) { 
            Console.WriteLine($"{name} waits to access a database"); 
            _semaphore.Wait(); 
            Console.WriteLine($"{name} was granted an access to a database"); 
            Thread.Sleep(TimeSpan.FromSeconds(seconds)); 
            Console.WriteLine($"{name} is completed"); 
            _semaphore.Release(); 
        }


        static void TestCounter(CounterBase c) { for (int i = 0; i < 100000; i++) { c.Increment(); c.Decrement(); } }
        static void MainLock(string[] args)
        {


            Console.WriteLine("Incorrect counter"); 
            var c = new Counter(); 
            var t1 = new Thread(() => TestCounter(c)); 
            var t2 = new Thread(() => TestCounter(c)); 
            var t3 = new Thread(() => TestCounter(c)); 
            t1.Start(); 
            t2.Start(); 
            t3.Start(); 
            t1.Join(); 
            t2.Join(); 
            t3.Join(); 
            Console.WriteLine($"Total count: {c.count}"); 
            Console.WriteLine("--------------------------"); 
            Console.WriteLine("Correct counter");
            var c1 = new CounterWithLock();
            t1 = new Thread(() => TestCounter(c1));
            t2 = new Thread(() => TestCounter(c1));
            t3 = new Thread(() => TestCounter(c1));
            t1.Start(); 
            t2.Start(); 
            t3.Start(); 
            t1.Join(); 
            t2.Join(); 
            t3.Join(); 
            Console.WriteLine($"Total count: {c1.count}");
        }

        static void PrintNumbers(){
            for (int i = 1; i <= 10;i++){
                Console.WriteLine(i);
            }
        }

        static void PrintNumbersWithDelay()
        {
            Console.WriteLine("Starting..."); for (int i = 1; i < 10; i++) { 
                Thread.Sleep(TimeSpan.FromSeconds(2)); 
                Console.WriteLine(i); 
            }
        }


        static void DoNothing() { 
            Thread.Sleep(TimeSpan.FromSeconds(2)); 
        }

        static void PrintNumbersWithStatus() { 
            Console.WriteLine("Starting..."); 
            Console.WriteLine(Thread.CurrentThread.ThreadState.ToString()); 
            for (int i = 1; i < 10; i++) 
            { 
                Thread.Sleep(TimeSpan.FromSeconds(2)); 
                Console.WriteLine(i); 
            } 
        }

    }

    public abstract class CounterBase{
        public abstract void Increment();
        public abstract void Decrement();
    }

    public class CounterWithLock : CounterBase
    {
        public object _syncRoute = new object();
        public int count { get; private set; }

        public override void Increment()
        {
            lock (_syncRoute)
            {
                count++;
            }

        }

        public override void Decrement()
        {
            count--;
        }
    }


        public class Counter : CounterBase
        {
            public object _syncRoute = new object();
            public int count { get; private set; }

            public override void Increment()
            {
                count++;

            }

            public override void Decrement()
            {
                count++;

            }
        }

       
   

}
