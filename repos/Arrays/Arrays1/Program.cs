
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays1
{
    internal class Program
    {
        public static int missingNumber()
        {
            int[] arr = { 1, 2, 4 };
            int n = arr.Length + 1;
            int res = n * (n + 1) / 2;
            int sum = 0;

            foreach (var item in arr)

            {
                sum += item;
            }
            int result = res - sum;
            return result;


        }
        static void Main(string[] args)
        {
            Console.WriteLine(Program.missingNumber());
        }
    }
}
