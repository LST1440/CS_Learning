using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    internal class Program
    {
        static void arrMin(int[] a,out int min)
        {
            min = a[0];
            for (int i = 1; i < a.Length; i++) {
                if (a[i] < min) 
                    min = a[i];
            }
        }
        static void Main(string[] args)
        {
            int[] num = new int[6];

            Console.WriteLine("請輸入6個整數......");
            for (int i = 0; i < 6; i++)
            {
                Console.Write("請輸入第" + (i + 1) + "個整數:");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            int min;
            arrMin(num,out min);
            Console.WriteLine();
            Console.WriteLine("最小值:" + min );
        }
    }
}
