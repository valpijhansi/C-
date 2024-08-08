using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bmw bmw = new Bmw();
            bmw.engineStatus();
            bmw.run();
        }
    }
}
