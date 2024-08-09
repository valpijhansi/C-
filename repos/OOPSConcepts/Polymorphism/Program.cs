using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            fruit f;
           f = new orange();
            f.type();

            f = new Apple();
            f.type();
        }
    }
}
