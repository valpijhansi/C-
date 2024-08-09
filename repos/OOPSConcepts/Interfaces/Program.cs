using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            shape s;
            s = new rectangle();
            s.perimeter();
            s.Area();

            s = new cylinder();
            
            
            //c.Height = 3;
            
            s.perimeter();
            s.Area();
        }
    }
}
