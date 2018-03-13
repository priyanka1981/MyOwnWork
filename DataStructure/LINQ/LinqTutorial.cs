using System;
using System.Linq;
namespace DataStructure.LINQ
{
    public class LinqTutorial
    {

        static void Main_Linq(string[] args)
        { 
          IntroLinq();
        }

        public LinqTutorial()
        {
        }

        public static void IntroLinq(){
            int[] numbers = { 0, 1, 2, 3, 4, 5, 6 };
            var numQuery = from num in numbers
                           where (num % 2 == 0)
                           select num;

            foreach (int num in numQuery)
                Console.WriteLine(num);

        }
    }
}
