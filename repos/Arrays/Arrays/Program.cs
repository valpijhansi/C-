
/* we can write square brackets after the data type 

--> int arr[] =  new int[n]; we declare an array in C# it shows compile time errors
--> an array is variable which store similar type of values.
--> once we initialize the array there is no chance to modify the array size because the size of the array is fixed.
--> we can decalre the array in three ways
   int[] arr = new int[5];
   int[] arr =  new int[] {1,2,3,4} it is called inline initialization
   int[] arr = {2,3,4,5,6}



  for (int i = 0; i < n; i++)
{
   Console.WriteLine(arr[i]); it will print all the elements in the array
  }
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Arrays
{

    internal partial class Program
    {

        static void Main(string[] args)
        {
           
          rotationOfAnArray rotate = new rotationOfAnArray();
            rotate.rotateFromLeftToRight();
        }
        static void sortingAlgorithm()

        {
            int[] arr = new int[] { 1, 2, 8, 10, 3, 5, 6 };
            int n = arr.Length;
            int temp;
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }

            }
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
