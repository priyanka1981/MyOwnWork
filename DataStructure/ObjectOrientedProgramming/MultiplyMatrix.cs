using System;
using System.Text;
namespace DataStructure.ObjectOrientedProgramming
{
    public class MultiplyMatrix
    {
        public MultiplyMatrix()
        {
           
        }

        static void Main_Pra(string[] args)
        {
            int[] a = { 1,1,1};
            int[] b = { 2,2,2};
           int num= Multiply(a,b);
        }

        public static int Multiply(int[] b1,int[] b2){
            int[] num = new int[5];
            int sum = 0;
            for (int i = 0; i <= b2.Length - 1;i++){
                int remender = 0;
                string number = string.Empty;
                for (int j = 0; j <= b1.Length - 1;j++){
                    int multiplication = b1[j] * b2[i];
                    if(multiplication >10 && i<b2.Length-1)
                    remender = multiplication % 10;
                    number = number.Insert(0,Convert.ToString(multiplication + remender));
                   
                }
                StringBuilder builder = new StringBuilder();
                for (int k = 0; k < i; k++)
                {

                    builder.Append("0");
                }
                number = number + builder.ToString();
                num[i] = Convert.ToInt32(number);
            }
            foreach(int number in num){
                sum += number;
            }
            return sum;
        }
    }
}
