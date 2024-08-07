using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayInFunctions
{
    internal class Program
    {
        public static void arrayInFunctions(int[] arr)
        {
            Console.WriteLine("Print the array elements");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            int[] arr2 = { 1,3,4,5 };

            Program.arrayInFunctions(arr);
            Program.arrayInFunctions(arr2);
        }
    }
}
