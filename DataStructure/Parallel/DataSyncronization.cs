using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Threading;

namespace DataStructure.Parallel
{
    public class DataSyncronization
    {
        private static object FirstObject;
        private static object SecondObject;
        public DataSyncronization()
        {
          

        }

        private static void ThreadJob(){
            lock (FirstObject){
                Console.WriteLine("Locking first Object from ThreaJob");
                lock(SecondObject){
                    Console.WriteLine("Locking second object from ThreadJob");
                }
            }
        }



        static void Main_DataSync(string[] args){
           //bool (100 + 1.0 / 3) - 100 == 1.0 / 3

            Thread t = new Thread(ThreadJob);
            t.Name = "test thread";
            t.Start();
            Thread.Sleep(1500);
            lock (SecondObject)
            {
                Console.WriteLine("Locking second Object from main....");
                lock (FirstObject)
                {
                    Console.WriteLine("Locking first object from main...");
                }
            }



            Console.Read();





            //var a = new Action(() => Console.Write("a"));
            //var b = new Action(() => Console.Write("a"));
            //var c = new Action(() => Console.Write("a"));

            //System.Threading.Tasks.Parallel.Invoke(a,b,c);
            //System.Threading.Tasks.Parallel.For(1, 11, i =>
            //                                      Console.WriteLine($"{i * i}"));

            //string[] words = { "what", "a", "night" };
            //System.Threading.Tasks.Parallel.ForEach(words, word =>
                                                    //Console.WriteLine($"{word} has length {word.Length}, task {Task.CurrentId}"));

            //Dictionary<string,string> dict = new Dictionary<string, string>();
            //var tasks = new List<Task>();
            //var ba = new BankAccount();
            //for (int i = 0; i <= 10; i++)
            //{
            //    tasks.Add(Task.Factory.StartNew(() => {
            //        for (int j = 0; j < 10; j++)
            //        {
            //            ba.Deposit(10);
            //        }
            //    }));

            //    tasks.Add(Task.Factory.StartNew(() => {
            //        for (int j = 0; j < 10; j++)
            //        {
            //            ba.Withdraw(10);
            //        }
            //    }));

            //}

            //Task.WaitAll(tasks.ToArray());
            //Console.Write($"Final Balance in an account is {ba.balance}"); 
        }

        public class BankAccount{
            public int balance { get; set; }

            public void Deposit(int amount){
                balance += amount;
            }

            public void Withdraw(int amount){
                balance -= amount;
            }
        }

        public void Method1(){
            lock (FirstObject)
                Console.Write("Locking m1 from first");
            
        }


    }
}
