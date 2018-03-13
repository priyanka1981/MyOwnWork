using System;
using System.Threading.Tasks;
namespace DataStructure.Parallel
{
    public class Parallel1
    {
        public Parallel1()
        {
        }

        static void Main_parallel(string[] args)
        {
            Task<int> task1= Task.Factory.StartNew(Write,1112);
            Console.Write("Task with id {task1.Id} is running of result" + task1.Result);
            Task<int> task2 = new Task<int>(Write,456);
            task2.Start();
            Console.Write("Task with id {task2.Id} is running of result" + task2.Result);
            Console.Write('-');
            Console.ReadKey();

        }

        static void Write(char ch)
        {
            int i = 10;
            while (i-- > 0)
            {
                Console.Write(ch);
            }
        }

        static int Write(object o)
        {

            return o.ToString().Length;

        }
    }

    
}
