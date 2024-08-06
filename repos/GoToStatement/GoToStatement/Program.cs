using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoToStatement
{
    internal class Program
    {
        static void Main(string[] args)

        {
        ineligble:
            Console.WriteLine("you are not eligible to vote");
            Console.WriteLine("Enter the age\n");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 18)
            {
                goto ineligble;
            }
            else
            {
                Console.WriteLine("You are eligible to vote");
            }
        }
    }
}
