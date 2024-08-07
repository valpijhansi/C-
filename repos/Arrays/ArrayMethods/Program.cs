using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMethods
{
    internal class Program
    {
        public static void printArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item+" ");
            }
        }
        static void Main(string[] args)
        {

            int[] arr = { 1, 20, 3, 4, 60, 7, 4, 12, };
            int[] arr1 = { 2, 3, 4, 5, 8, };
            Console.WriteLine("First array length:"+arr.Length);
            Array.Sort(arr);
            Console.WriteLine("First Array elements:");
            printArray(arr);
            Console.WriteLine(Array.IndexOf(arr, 60));//it will print index of a given element

            Array.Copy(arr1, arr,arr1.Length);// in this method it will copy one elements from one array to another array
            Console.WriteLine(arr1);
            //Console.WriteLine();

            Console.WriteLine("Print second Array Elements");
            printArray(arr1 );
            Array.Reverse(arr1);//this method prints the elements in reverse order
            Console.WriteLine("Print arra1 in reverse oreder");
            printArray(arr1);
            

        }
    }
}
