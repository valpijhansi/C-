using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClassExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Min(a,b));
            Console.WriteLine(Math.Max(a,b));
            Console.WriteLine(Math.Sqrt(a));
            Console.WriteLine(Math.Sqrt(b));
            //Console.WriteLine(Math.Tan();
        }
    }
}
