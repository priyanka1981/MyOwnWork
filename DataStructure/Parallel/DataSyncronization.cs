using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace DataStructure.Parallel
{
    public class DataSyncronization
    {
        public DataSyncronization()
        {
          

        }

        static void Main(string[] args){
           //bool (100 + 1.0 / 3) - 100 == 1.0 / 3
            var a = new Action(() => Console.Write("a"));
            var b = new Action(() => Console.Write("a"));
            var c = new Action(() => Console.Write("a"));

            System.Threading.Tasks.Parallel.Invoke(a,b,c);
            System.Threading.Tasks.Parallel.For(1, 11, i =>
                                                  Console.WriteLine($"{i * i}"));

            string[] words = { "what", "a", "night" };
            System.Threading.Tasks.Parallel.ForEach(words, word =>
                                                    Console.WriteLine($"{word} has length {word.Length}, task {Task.CurrentId}"));

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


    }
}
