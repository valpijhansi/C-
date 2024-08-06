

using System;
using System.Security.Policy;

namespace Arrays
{

    internal partial class Program
    {
        public class rotationOfAnArray{ 
            public void rotateFromLeftToRight()
            {
                int[] arr = {1,2, 3, 4, 5};

               
                int last = arr[arr.Length-1];//save the last element of the array
                
                for (int i = arr.Length - 1; i > 0; i--) // Shift all elements to the right by one position
                {
                    arr[i] = arr[i - 1];
                }
                arr[0] = last;

                foreach (var item in arr)
                {
                    Console.WriteLine(item+"  ");

                }


            }

         }
    } 
 }

