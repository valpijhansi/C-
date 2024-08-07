using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minNumberInArray
{
    internal class Program
    {
        public static void minNumber(int[] num)
        {
            int min = num[0];
            for (int i = 1; i < num.Length; i++)
            {
                if (num[i] < min)
                {
                    min = num[i];
                }
                Console.WriteLine(min);
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 20, 10, 15, 30, 20, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, };
            Program.minNumber(arr);
        }
    }
}
