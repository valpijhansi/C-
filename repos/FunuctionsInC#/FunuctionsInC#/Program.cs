using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunuctionsInC_
{
    internal class Program
    {
        public int Area(int a,int b)
        {
            return a * b;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.Area(2, 6));
        }
    }
}
