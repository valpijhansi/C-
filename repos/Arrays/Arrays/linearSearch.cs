


using System;
using System.Runtime.InteropServices;

namespace Arrays
{
    public class linearSearch
    {
        public  void PerformLinearSearch()
        {
            // Sample array
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Asking user for the number to search
            Console.WriteLine("Enter the number to search:");
            int searchNumber = int.Parse(Console.ReadLine());

            // Performing linear search
            bool found = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == searchNumber)
                {
                    Console.WriteLine($"Number {searchNumber} found at index {i}.");
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine($"Number {searchNumber} not found in the array.");
            }
        }
    }
}
