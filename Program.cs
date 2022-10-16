using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_IntSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// 輸入三個整數, 請把這三個數由小到大輸出
            /// 
            Console.WriteLine("請輸入三個整數：");
            Console.Write("第一個數字：");
            string num1 = Console.ReadLine();
            Console.Write("第二個數字：");
            string num2 = Console.ReadLine();
            Console.Write("第三個數字：");
            string num3 = Console.ReadLine();

            int numone = int.Parse(num1);
            int numtwo = int.Parse(num2);  
            int numthree = int.Parse(num3);

            int[] bigandsmall = new int[3] { numone, numtwo, numthree };

            Array.Sort(bigandsmall);

            for (int i = 0; i < bigandsmall.Length; i++)
            {
                Console.Write(bigandsmall[i] + " ");
            }

            Console.Read();
        }
    }
}
